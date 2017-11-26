-- ####################################################################
-- ASESORIAS
-- Diseñada para el proyecto del sistema de manejo de las asesorías.
-- ####################################################################

DROP DATABASE IF EXISTS asesorias;
CREATE DATABASE asesorias;

USE asesorias;

-- ####################################################################
-- TABLAS
-- ####################################################################

-- TABLA: horaslibres
-- Almacena las horas disponibles de un asesor para dar asesorías.

CREATE TABLE horaslibres (
	nocontrol	char(9)			not null,
    dia			enum('LUN', 'MAR', 'MIE', 'JUE', 'VIE') not null,
    hora		time			not null
);

-- TABLA: oferta
-- Cada registro contiene la informacion de un asesor y una materia 
-- que oferta como disponible para asesorías.

CREATE TABLE oferta (
	idoferta	int				primary key auto_increment,
	nocontrol 	char(9) 		not null,
    idmateria	int 			not null
);

-- TABLA: asesoria
-- Almacena la información de las asesorías y su estatus actual.

CREATE TABLE asesoria (
	idasesoria	int				primary key auto_increment,
    nocontrol 	char(9) 		not null,
    idmateria	int 			not null,
    estatus		enum('ACTIVA', 'FINALIZADA') not null
);

-- TABLA: detalleasesoria
-- Cada registro almacena la clave de una asesoría y de un alumno
-- que la toma.

CREATE TABLE detalleasesoria (
	idasesoria	int				not null,
    nocontrol	char(9)			not null
);

-- TABLA: solicitud
-- Almacena la información de los registros que se generan cuando
-- un tutor solicita una asesoría para un grupo de alumnos.

CREATE TABLE solicitud (
	idsolicitud	int				primary key auto_increment,
    idmateria	int 			not null,
    idtutor		int				not null,
    estatus		enum('PENDIENTE', 'ACEPTADA', 'RECHAZADA') not null,
    horario 	text 			null	,
    notas		text			null,
    idasesoria	int				null
);

-- TABLA: detallesolicitud
-- Cada registro almacena la clave de una solicitud de asesoríalter
-- y de un alumno que está en el grupo para el que se solicita.

CREATE TABLE detallesolicitud (
	idsolicitud	int				not null,
    nocontrol	char(9)			not null,
    constraint	primary key(idsolicitud, nocontrol)
);

-- TABLA: respuesta
-- Almacena el registro de las respuesta a las solicitudes de asesorías.

CREATE TABLE respuesta (
	idrespuesta	int				primary key auto_increment,
    idsolicitud	int				not null,
    idtutor		int				not null,
    resp		enum('ACEPTADA', 'RECHAZADA') not null
);

-- TABLA: detallerespuesta
-- En caso de que una respuesta sea afirmativa, deberá contar con una lista
-- de asesores capaces de atender la peticion.
-- En esta tabla se mantiene el registro de los asesores propuestos.

CREATE TABLE detallerespuesta (
	idrespuesta	int				not null,
    nocontrol	char(9)			not null,
    constraint	primary key(idrespuesta, nocontrol)
);

-- TABLA: sesion
-- Mantiene un registro sobre si una determinad sesión se llevó a cabo. 
-- En caso afirmativo se almacenan detalles como el lugar, la fecha y
-- la hora; en caso contrario se almacenan notas del porqué no select
-- pudo concretar la sesión

CREATE TABLE sesion (
	idsesion	int				primary key auto_increment,
    idasesoria	int				not null,
    estatus		enum('REALIZADA', 'CANCELADA') not null,
    lugar		varchar(32)		not null,
    fecha		date			not null,
    hora		time			not null,
    notas		text			null
);

-- TABLA: detallesesion
-- Mantiene un registro de la asistencia a las sesiones.

CREATE TABLE detallesesion (
	idsesion	int				not null,
    nocontrol	char(9)			not null,
    asistio     bool			not null,
    constraint	primary key(idsesion, nocontrol)
);

-- ####################################################################
-- VISTAS
-- ####################################################################

CREATE VIEW asesor AS    
SELECT 
	G.idTutor,
	A.noControl,
    A.nombre,
    A.apellido1,
    A.apellido2,
    A.correo,
    A.semestre,
    A.idCarrera    
FROM 
	SICE.alumnos A,
    SICE.alumnosgrupostutorias D,
    SICE.grupostutorias G
WHERE
	A.noControl = D.noControl AND
    D.idGrupoTutoria = G.idGrupoTutoria
;

CREATE VIEW MateriasOfertadas AS
SELECT 
	O.idoferta,
    O.nocontrol,
    O.idmateria,
    M.nombre,
    M.idCarrera
FROM 
	asesorias.oferta O, 
    SICE.materias M 
WHERE 
	O.idMateria = M.idMateria
;

CREATE VIEW AlumnosAsesoria AS
SELECT 
	D.idasesoria,
    A.noControl,
    A.nombre,
    A.apellido1,
    A.apellido2,
    A.correo,
    A.semestre,
    A.idCarrera
FROM 
	detalleasesoria D,
    SICE.alumnos A
WHERE
	D.nocontrol = A.noControl
;

CREATE VIEW AlumnosSolicitud AS
SELECT 
	D.idsolicitud,
    A.noControl,
    A.nombre,
    A.apellido1,
    A.apellido2,
    A.correo,
    A.semestre,
    A.idCarrera
FROM 
	solicitud S,
	detallesolicitud D,
    SICE.alumnos A
WHERE
	S.idsolicitud = D.idsolicitud AND
	D.nocontrol = A.noControl
;

-- ####################################################################
-- REPORTES
-- ####################################################################

CREATE VIEW ReporteAsesores AS
SELECT
	C.Carrera,
    A.NoControl,
    concat(A.Nombre, ' ', A.Apellido1, ' ', A.Apellido2) as Nombre,
    concat(T.Nombre, ' ', T.Apellido1, ' ', T.Apellido2) as Tutor,
    ( SELECT count(*) FROM asesorias.asesoria X WHERE X.nocontrol = A.noControl ) as 'Asesorías totales',
    ( SELECT count(*) FROM asesorias.asesoria X WHERE X.nocontrol = A.noControl AND X.estatus = "ACTIVA") as 'Asesorías actuales'
FROM 
	SICE.carreras C,
    asesorias.asesor A,
    SICE.tutores T
WHERE
	C.idCarrera = A.idCarrera AND
    A.idTutor = T.idTutor
ORDER BY
	C.Carrera, A.noControl
;

-- ####################################################################
-- PROCEDIMIENTOS ALMACENADOS
-- ####################################################################

DELIMITER $$

CREATE PROCEDURE SolicitudesPendientes (IN _idtutor int)
BEGIN
	SELECT 
		S.idsolicitud,
		S.idmateria,
		S.idtutor,
		S.estatus,
		S.horario,
		S.notas,
		S.idasesoria
	FROM 
		solicitud S    
	WHERE 
		estatus = 'PENDIENTE' AND 
		idtutor != _idtutor
	HAVING
		( SELECT count(*) FROM respuesta R WHERE S.idsolicitud = R.idsolicitud AND R.idtutor = _idtutor) = 0
	;
END $$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE ConsultarSolicitudes(IN _idtutor INT)
BEGIN
	SELECT * FROM solicitud WHERE idtutor = _idtutor;
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE ConsultarSolicitud(IN _idsolicitud INT)
BEGIN
	SELECT * FROM solicitud WHERE idsolicitud = _idsolicitud;
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE IntegrantesSolicitud (IN _idsolicitud INT)
BEGIN
	SELECT * FROM AlumnosSolicitud WHERE idsolicitud = _idsolicitud;
END $$

DELIMITER ;

-- ####################################################################
-- DATOS DE PRUEBA
-- ####################################################################
    
INSERT INTO horaslibres VALUES
	("S15120048", "LUN", "14:00"),
    ("S15120048", "MAR", "14:00"),
    ("S15120048", "JUE", "14:00"),
	("S15120048", "VIE", "09:00"),
    ("S15120048", "VIE", "10:00"),
    ("S15120048", "VIE", "12:00"),
    ("S15120048", "VIE", "14:00");
    
INSERT INTO oferta VALUES
	(null, "S15120048", 1),
    (null, "S15120048", 5),
    (null, "S15120048", 6),
    (null, "S15120054", 2),
    (null, "S15120054", 3),
    (null, "S15120054", 6),
    (null, "E14120310", 2),
    (null, "E14120310", 7),
    (null, "E14120310", 8),
    (null, "E14120310", 9);
    
INSERT INTO asesoria VALUES
	(null, "S15120048", 1, "ACTIVA"),
    (null, "S15120054", 6, "FINALIZADA");
    
INSERT INTO detalleasesoria VALUES
	(1, "I11120182"),
    (1, "G15120367"),
    (1, "S15120065"),
    (2, "S15120065"),
    (2, "E12120193");	
    
INSERT INTO solicitud VALUES 
	(1, 6, 3, "PENDIENTE", "09:00", "Árboles", null);
 
 INSERT INTO detallesolicitud VALUES 
	(1, "E14120310"),
    (1, "S15120032"),
    (1, "S15120065");
 
INSERT INTO sesion VALUES
	(null, 1, "REALIZADA", "B6", "2017-11-24", "11:00:00", "");