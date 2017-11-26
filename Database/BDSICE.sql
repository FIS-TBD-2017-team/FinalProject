-- ####################################################################
-- SICE
-- Emula el funcionamiento de la base de datos de la institución. Solo 
-- se muestra la parte relevante para el proyecto. 
-- No está permitido hacer modificaciones a esta base de datos
-- ####################################################################

DROP DATABASE IF EXISTS SICE;
CREATE DATABASE SICE;

USE SICE;

-- ####################################################################
-- TABLAS
-- ####################################################################

CREATE TABLE Carreras (
	idCarrera				int				primary key auto_increment,
    Carrera					varchar(60)		not null,
    CarreraCorto			varchar(45)		not null
);

CREATE TABLE Materias (
	idMateria				int				primary key auto_increment,
    nombre					varchar(45)		not null,
    idCarrera				int				null
);

CREATE TABLE Grupos (
	idGrupo					int				primary key auto_increment,
    clave					char(4)			not null,
    idMateria				int				not null,
    constraint				foreign key(idMateria) references Materias(idMateria)
);

CREATE TABLE Alumnos (
	noControl				char(9)			primary key,
    nombre					varchar(45)		not null,
    apellido1				varchar(45) 	not null,
    apellido2				varchar(45) 	null,
    correo					varchar(100)	null,
    semestre				tinyint			not null,
    idCarrera				int				not null,
    constraint				foreign key(idCarrera) references Carreras(idCarrera)
);

CREATE TABLE Tutores (
	idTutor					int				primary key auto_increment,
    nombre					varchar(45)		not null,
    apellido1				varchar(45) 	not null,
    apellido2				varchar(45) 	null,
    usuario					varchar(45)		not null unique,
    password				char(128)		not null,
    tipo					enum('tutor', 'coordinador') not null default 'tutor'
);

CREATE TABLE GruposTutorias (
	idGrupoTutoria			int				primary key auto_increment,
    actividad				varchar(45)		not null,
    idTutor					int				not null,
    constraint				foreign key(idTutor) references Tutores(idTutor)
);

CREATE TABLE AlumnosGruposTutorias (
	idAlumnoGrupoTutoria	int				primary key auto_increment,
    idGrupoTutoria			int				not	null,
    noControl				char(9)			not null,
    constraint				foreign key(noControl) references Alumnos(noControl),
    constraint 				foreign key(idGrupoTutoria) references GruposTutorias(idGrupoTutoria)
);

-- ####################################################################
-- TRIGGERS
-- ####################################################################

DELIMITER $$

CREATE TRIGGER SICE.VALIDA_CORREO
BEFORE UPDATE
ON SICE.alumnos FOR EACH ROW
BEGIN
	IF NOT ((NEW.correo LIKE "%@%.%") OR (NEW.correo = "")) THEN
		SET NEW.correo = "";
	END IF;
END$$

DELIMITER ;

-- ####################################################################
-- DATOS DE PRUEBA
-- ####################################################################

INSERT INTO Carreras VALUES
	(1, "Ingeniería en Sistemas Computacionales", "S. COMP."),
    (2, "Ingeniería en Electrónica", "ELECTRONICA"),
    (3, "Ingeniería en Gestión Empresarial", "GESTION"),
    (4, "Ingeniería en Sistemas Automotrices", "S. AUTO."),
    (5, "Ingeniería Industrial", "INDUSTRIAL");

INSERT INTO Materias VALUES
	(1, "Matematicas Discretas", 1),
    (2, "Calculo Diferencial", -1),
    (3, "Calculo Integral", -1),
    (4, "Calculo Vectorial", -1),
    (5, "Fundamentos de programacion", 1),
    (6, "Estructura de datos", 1),
    (7, "Quimica", -1),
    (8, "Fisica", -1),
    (9, "Mecanica", 2);
    
INSERT INTO Grupos VALUES 
	(1, "S53A", 5),
    (2, "S55B", 1);

INSERT INTO Alumnos VALUES
	("S15120049", "Juan Carlos", "Hurtado", "Morales", null, 5, 1),
	("E12120193", "Emisael", "Alvarado", "Rueda", null, 9, 2),
    ("G12120089", "Gabriela", "Alvarez", "Arreola", null, 9, 3),
    ("G15120367", "Nayely", "Perez", "Villanueva", null, 5, 3),
    ("S15120054", "Tania", "Martinez", "Villagomez", null, 5, 1),
    ("E14120310", "Maria Isabel", "Ramiez", "Martinez", null, 7, 2),
    ("I11120182", "Azucena", "Rico", "Torres", null, 10, 5),
    ("S15120033", "Ricardo Fabian", "Juarez", "Santoyo", null, 5, 1),   
    ("S15120065", "Jose Antonio", "Sanchez", "Hernandez", null, 5, 1),
    ("S15120040", "Jesus Manuel", "Ruiz", "Sanchez", null, 5, 1),
    ("S15120048", "Orlando Isay", "Mendoza", "García", null, 5, 1),         
    ("S15120032", "Miguel Alejandro", "Vazquez", "Alberto", null, 5, 1),
    ("S15120030", "Jose Guadalupe", "Rivera", "Alcantar", null, 5, 1),
    ("G13120301", "Misael", "Ramirez", "Guzman", null, 9, 3),
    ("S15120036", "Efrain Jared", "Ramirez", "Diaz", null, 5, 1);

INSERT INTO Tutores VALUES 
	(1, "Jeziel", "Vazquez", "Nava", "jeziel", sha2("jeziel", 512), "tutor"),
    (2, "Luis German", "Gutierrez", "Torres", "german", sha2("german", 512), "tutor"),
    (3, "Patricia", "Vega", "Flores", "paty", sha2("paty", 512), "tutor"),
    (4, "Efren", "Vega", "Chavez", "efren", sha2("efren", 512), "tutor");
    
INSERT INTO GruposTutorias VALUES
	(1, "Asesorias", 3),
    (2, "Asesorias", 1),
    (3, "Revista", 4);
    
INSERT INTO AlumnosGruposTutorias VALUES
	(null, 1, "S15120033"),
    (null, 1, "S15120054"),
    (null, 1, "S15120048"),
    (null, 2, "I11120182"),
    (null, 2, "E14120310"),
    (null, 3, "S15120036");