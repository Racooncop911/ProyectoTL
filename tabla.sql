drop TABLE Periodos
drop TABLE Alumnos
drop TABLE Docentes
drop TABLE Materias
drop TABLE Tareas
drop TABLE Sesiones

 CREATE TABLE Periodos(
	IDPeriodo bigint NOT NULL PRIMARY KEY,
	FechaInicio datetime NOT NULL,
	FechaCierre datetime NOT NULL
	
)

 CREATE TABLE Alumnos(
	IDAlumno bigint PRIMARY KEY,
	NoControl int NOT NULL,
	Nombre nvarchar(60) NOT NULL,
	ApPaterno nvarchar(60) NOT NULL,
	ApMaterno nvarchar(60) NULL,
	Carrera nvarchar(40) NOT NULL,
	Telefono numeric(10) NULL,
	Correo nvarchar(60) NULL
 
)
  CREATE TABLE Docentes(
	IDDoc bigint PRIMARY KEY,
	RFC nvarchar(13) NOT NULL,
	DNombre nvarchar(60) NOT NULL,
	DApPaterno nvarchar(60) NOT NULL,
	DApMaterno nvarchar(60) NULL
)
CREATE TABLE Materias(
	IDMat bigint PRIMARY KEY,
	Clave nvarchar(50) NOT NULL,
	Creditos INT NOT NULL,
	Nombre nvarchar(80) NOT NULL
)
CREATE TABLE Tareas(
	IDTareas bigint PRIMARY KEY,
	IDMat bigint REFERENCES Materias,
	Titulo nvarchar(80),
	Descripcion text,
	FechaEntrega datetime,
)

CREATE TABLE Sesiones(
	IDSesion bigint PRIMARY KEY,
	Dia  date NOT NULL,
	Hora time NOT NULL,
	IDAlumno bigint REFERENCES Alumnos,
	IDDoc bigint REFERENCES Docentes,
	IDMat bigint REFERENCES Materias,
	Aula varchar(4)
)