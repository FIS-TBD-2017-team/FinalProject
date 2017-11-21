DROP DATABASE IF EXISTS asesorias;

-- ####################################################################
-- BASE DE DATOS: asesorias
-- Diseñada para el proyecto del sistema de manejo de las asesorías.
-- ####################################################################

-- ####################################################################
-- TABLAS
-- ####################################################################

CREATE DATABASE asesorias;

USE asesorias;

-- TABLA: tutor
-- Almacena información de los tutores que están en 
-- el área de asesorías.

CREATE TABLE tutor (
	idtutor		int				primary key auto_increment,
    nombre 		varchar(30) 	not null,
    apellidos 	varchar(30) 	not null,
    usuario		varchar(30)		not null,
    pass		char(128)		not null
);

-- TABLA: asesor
-- Almacena información de los alumnos registrados como asesores.

CREATE TABLE asesor (
	nocontrol 	char(9) 		primary key,
    nombre 		varchar(30) 	not null,
    apellidos 	varchar(30) 	not null,
    activo 		bool 			not null,
    carrera		varchar(35)		not null,
    semestre 	int 			not null,
    correo 		varchar(40) 	null,
    telefono 	varchar(20) 	null,
    idtutor		int				not null,
    constraint  foreign key(idtutor) references tutor(idtutor)
);

-- TABLA: horaslibres
-- Almacena las horas disponibles de un asesor para dar asesorías.

CREATE TABLE horaslibres (
	nocontrol	char(9)			not null,
    dia			enum('LUN', 'MAR', 'MIE', 'JUE', 'VIE') not null,
    hora		time			not null,
    constraint  foreign key(nocontrol) references asesor(nocontrol)
);

-- TABLA: materia
-- Almacena los datos de las materias

CREATE TABLE materia (
	idmateria	int 			primary key auto_increment,
    nombre		varchar(32)		not null
);

-- TABLA: oferta
-- Cada registro contiene la informacion de un asesor y una materia 
-- que oferta como disponible para asesorías.

CREATE TABLE oferta (
	idoferta	int				primary key auto_increment,
	nocontrol 	char(9) 		not null,
    idmateria	int 			not null,
    constraint  foreign key(nocontrol) references asesor(nocontrol),
    constraint  foreign key(idmateria) references materia(idmateria)
);

-- TABLA: alumno
-- Almacena los datos de los alumnos que toman asesorías.

CREATE TABLE alumno (
	nocontrol 	char(9) 		primary key,
    nombre 		varchar(30) 	not null,
    apellidos 	varchar(30) 	not null,
    semestre 	int 			not null,
    correo 		varchar(40) 	null,
    telefono 	varchar(20) 	null,
    idtutor		int				not null,
    constraint  foreign key(idtutor) references tutor(idtutor)
);

-- TABLA: asesoria
-- Almacena la información de las asesorías y su estatus actual.

CREATE TABLE asesoria (
	idasesoria	int				primary key auto_increment,
    nocontrol 	char(9) 		not null,
    idmateria	int 			not null,
    estatus		enum('ACTIVA', 'FINALIZADA') not null,
    constraint  foreign key(nocontrol) references asesor(nocontrol),
    constraint  foreign key(idmateria) references materia(idmateria)
);

-- TABLA: detalleasesoria
-- Cada registro almacena la clave de una asesoría y de un alumno
-- que la toma.

CREATE TABLE detalleasesoria (
	idasesoria	int				not null,
    nocontrol	char(9)			not null,
    constraint  foreign key(idasesoria) references asesoria(idasesoria),
    constraint  foreign key(nocontrol) references alumno(nocontrol)
);

-- TABLA: solicitud
-- Almacena la información de los registros que se generan cuando
-- un tutor solicita una asesoría para un grupo de alumnos.

CREATE TABLE solicitud (
	idsolicitud	int				primary key auto_increment,
    idmateria	int 			not null,
    idtutor		int				not null,
    estatus		enum('PENDIENTE', 'RECHAZADA', 'ACEPTADA') not null,
    notas		text			null,
    idasesoria	int				null,
    constraint  foreign key(idmateria) references materia(idmateria),
    constraint  foreign key(idtutor) references tutor(idtutor)
);

-- TABLA: detallesolicitud
-- Cada registro almacena la clave de una solicitud de asesoríalter
-- y de un alumno que está en el grupo para el que se solicita.

CREATE TABLE detallesolicitud (
	idsolicitud	int				not null,
    nocontrol	char(9)			not null,
    constraint	primary key(idsolicitud, nocontrol),
    constraint  foreign key(idsolicitud) references solicitud(idsolicitud),
    constraint  foreign key(nocontrol) references alumno(nocontrol)
);

-- TABLA: respuesta
-- Almacena el registro de las respuesta a las solicitudes de asesorías.

CREATE TABLE respuesta (
	idrespuesta	int				primary key auto_increment,
    idsolicitud	int				not null,
    idtutor		int				not null,
    resp		enum('ACEPTADA', 'RECHAZADA') not null,
    constraint  foreign key(idsolicitud) references solicitud(idsolicitud),
    constraint  foreign key(idtutor) references tutor(idtutor)
);

-- TABLA: detallerespuesta
-- En caso de que una respuesta sea afirmativa, deberá contar con una lista
-- de asesores capaces de atender la peticion.
-- En esta tabla se mantiene el registro de los asesores propuestos.

CREATE TABLE detallerespuesta (
	idrespuesta	int				not null,
    nocontrol	char(9)			not null,
    constraint	primary key(idrespuesta, nocontrol),
    constraint	foreign key(nocontrol) references asesor(nocontrol)
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
    notas		text			null,
    constraint 	foreign key(idasesoria) references asesoria(idasesoria)
);

-- TABLA: detallesesion
-- Mantiene un registro de la asistencia a las sesiones.

CREATE TABLE detallesesion (
	idsesion	int				not null,
    nocontrol	char(9)			not null,
    asistio     bool			not null,
    constraint	primary key(idsesion, nocontrol),
    constraint	foreign key(idsesion) references sesion(idsesion),
    constraint	foreign key(nocontrol) references asesor(nocontrol)
);

-- ####################################################################
-- VISTAS
-- ####################################################################

CREATE VIEW materiasofertadas AS
SELECT 
	O.idoferta,
	A.nocontrol,
    M.idmateria,
    M.nombre
FROM 
	asesorias.asesor A,
    asesorias.oferta O,
	asesorias.materia M
WHERE 
	A.nocontrol = O.nocontrol AND
    M.idmateria = O.idmateria
;

CREATE VIEW asesoriasactivas AS
SELECT
	B.idtutor,
	A.idasesoria,
    M.nombre,
    A.nocontrol,
    concat(B.nombre, " ", B.apellidos) as nombreasesor,
    (
		SELECT
			count(AD.nocontrol)
		FROM
			detalleasesoria AD
		WHERE
			AD.idasesoria = A.idasesoria
	) as alumnos
FROM
	asesoria A,
    materia M,
    asesor B
WHERE
	A.nocontrol = B.nocontrol AND
    A.idmateria = M.idmateria AND 
    A.estatus = "ACTIVA"
;

SELECT * FROM tutor;

-- ####################################################################
-- DATOS DE PRUEBA
-- ####################################################################

INSERT INTO tutor VALUES 
	(null, "Jeziel", "Vazquez Nava", "jeziel", sha2("root", 512)),
    (null, "Luis German", "Gutierrez Torres", "german", sha2("german", 512)),
    (null, "Patricia", "Vega Flores", "paty", sha2("paty", 512)),
    (null, "Efren", "Vega Chavez", "efren", sha2("efren", 512));
    
INSERT INTO asesor VALUES
	("S15120048", "Orlando Isay", "Mendoza Garcia", true, "Ing. Sistemas Computacionales", 5, "orlandoisay@gmail.com", "445 123 2953", 3),
    ("S15120054", "Tania", "Martinez Villagomez", true, "Ing. Sistemas Computacionales", 5, "thanya.mav@gmail.com", "445 123 5564", 3),
    ("E15120031", "Kevin", "Lopez Gomez", true, "Ing. Electronica", 4, "kelo1996@outlook.com", "445 929 1234", 1);
    
INSERT INTO horaslibres VALUES
	("S15120048", "LUN", "14:00"),
    ("S15120048", "MAR", "14:00"),
    ("S15120048", "JUE", "14:00"),
	("S15120048", "VIE", "09:00"),
    ("S15120048", "VIE", "10:00"),
    ("S15120048", "VIE", "12:00"),
    ("S15120048", "VIE", "14:00");
    
INSERT INTO materia VALUES
	(null, "Matematicas Discretas"),
    (null, "Calculo Diferencial"),
    (null, "Calculo Integral"),
    (null, "Calculo Vectorial"),
    (null, "Fundamentos de programacion"),
    (null, "Estructura de datos"),
    (null, "Quimica"),
    (null, "Fisica"),
    (null, "Mecanica");
    
INSERT INTO oferta VALUES
	(null, "S15120048", 1),
    (null, "S15120048", 5),
    (null, "S15120048", 6),
    (null, "S15120054", 2),
    (null, "S15120054", 3),
    (null, "S15120054", 6),
    (null, "E15120031", 2),
    (null, "E15120031", 7),
    (null, "E15120031", 8),
    (null, "E15120031", 9);
    
INSERT INTO alumno VALUES
	("I14120221", "Eliezier", "Abonce Martinez", 7, "Eliezier@gmail.com", "445 241 2231", 4),
    ("D14120154", "Juan", "Aboytes Martinez",  7, "aboytes@gmail.com", "445 231 2561", 4),
    ("G15120391", "Jaime", "Berumen Orozco",  5, "berumen@outlook.com", "445 923 4234", 2);
    
INSERT INTO asesoria VALUES
	(null, "S15120048", 1, "ACTIVA"),
    (null, "S15120054", 6, "FINALIZADA");
    
INSERT INTO detalleasesoria VALUES
	(1, "G15120391"),
    (1, "D14120154"),
    (2, "D14120154");	