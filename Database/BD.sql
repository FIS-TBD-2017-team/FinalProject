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
    estatus		enum('PENDIENTE', 'RECHAZADA', 'ACEPTADA') not null,
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