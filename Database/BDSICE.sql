DROP DATABASE SICE;
CREATE DATABASE SICE;

USE SICE;

CREATE TABLE Carreras (
	idCarrera				int				primary key,
    Carrera					varchar(60)		not null,
    CarreraCorto			varchar(45)		not null
);

CREATE TABLE Materia (
	idMateria				int				primary key,
    nombre					varchar(45)		not null,
    idCarrera				int				null,
    constraint				foreign key(idCarrera) references Carreras(idCarrera)
);

CREATE TABLE Grupos (
	idGrupo					int				primary key auto_increment,
    clave					char(4)			not null,
    idMateria				int				not null,
    constraint				foreign key(idMateria) references Materia(idMateria)
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
	idTutor					int				primary key,
    nombre					varchar(45)		not null,
    apellido1				varchar(45) 	not null,
    apellido2				varchar(45) 	null,
    usuario					varchar(45)		not null unique,
    password				varchar(45)		not null,
    tipo					enum('tutor', 'coordinador') not null default 'tutor'
);

CREATE TABLE GruposTutorias (
	idGrupoTutoria			int				primary key,
    actividad				varchar(45)		not null,
    idTutor					int				not null,
    constraint				foreign key(idTutor) references Tutores(idTutor)
);

CREATE TABLE AlumnosGruposTutorias (
	idAlumnoGrupoTutoria	int				primary key,
    idGrupoTutoria			int				not	null,
    noControl				char(9)			not null,
    constraint				foreign key(noControl) references Alumnos(noControl),
    constraint 				foreign key(idGrupoTutoria) references GruposTutorias(idGrupoTutoria)
);
