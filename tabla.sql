drop TABLE Periodos
drop TABLE Alumnos
drop TABLE Docentes
drop TABLE Materias
drop TABLE Tareas
drop TABLE Sesiones

 CREATE TABLE Periodo(
	IDPeriodo bigint NOT NULL PRIMARY KEY,
	FechaInicio datetime NOT NULL,
	FechaCierre datetime NOT NULL
	
)

 CREATE TABLE Alumno(
	IDAlumno bigint PRIMARY KEY,
	NoControl int NOT NULL,
	Nombre nvarchar(60) NOT NULL,
	ApPaterno nvarchar(60) NOT NULL,
	ApMaterno nvarchar(60) NULL,
	Carrera nvarchar(40) NOT NULL,
	Telefono numeric(10) NULL,
	Correo nvarchar(60) NULL
 
)
  CREATE TABLE Docente(
	IDDoc bigint PRIMARY KEY,
	RFC nvarchar(13) NOT NULL,
	DNombre nvarchar(60) NOT NULL,
	DApPaterno nvarchar(60) NOT NULL,
	DApMaterno nvarchar(60) NULL
)
CREATE TABLE Materia(
	IDMat bigint PRIMARY KEY,
	Clave nvarchar(50) NOT NULL,
	Creditos INT NOT NULL,
	Nombre nvarchar(80) NOT NULL
)
CREATE TABLE Tarea(
	IDTareas bigint PRIMARY KEY,
	IDMat bigint REFERENCES Materia,
	Titulo nvarchar(80),
	Descripcion text,
	FechaEntrega datetime,
)

CREATE TABLE Sesion(
	IDSesion bigint PRIMARY KEY,
	Dia  date NOT NULL,
	Hora time NOT NULL,
	IDAlumno bigint REFERENCES Alumno,
	IDDoc bigint REFERENCES Docente,
	IDMat bigint REFERENCES Materia,
	Aula varchar(4)
)