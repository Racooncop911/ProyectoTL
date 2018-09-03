 drop TABLE Periodos
 drop TABLE Alumnos
 drop TABLE Docentes
 drop TABLE Materias
 drop TABLE Tareas
 drop TABLE Sesiones

 CREATE TABLE Periodos(
	IDPeriodo bigint NOT NULL,
	FechaInicio datetime NOT NULL,
	FechaCierre datetime NOT NULL
	
)
 CREATE TABLE Alumnos (
	IDAlumno bigint PRIMARY KEY,
	NoControl int NOT NULL,
	Nombre nvarchar(200) NOT NULL,
	ApPaterno nvarchar(200) NOT NULL,
	ApMaterno nvarchar(200) NULL,
	Carrera nvarchar(200) NOT NULL,
	Telefono nvarchar(200) NULL,
	Correo nvarchar(200) NULL
 
)
  CREATE TABLE Docentes (
	IDDoc bigint PRIMARY KEY,
	RFC nvarchar(200) NOT NULL,
	DNombre nvarchar(200) NOT NULL,
	DApPaterno nvarchar(200) NOT NULL,
	DApMaterno nvarchar(200) NULL
)
CREATE TABLE Materias (
	IDMat bigint PRIMARY KEY,
	Clave nvarchar(100) NOT NULL UNIQUE,,
	Creditos INT NOT NULL,
	NombreM nvarchar(200) NOT NULL
)
CREATE TABLE Tareas (
	IDTareas bigint PRIMARY KEY,
****	NombreM REFERENCES 
	Titulo nvarchar(200)
	Descripcion
	FechaEntrega
)

CREATE TABLE Sesiones(
	IDSesion PRIMARY KEY,
	Hora time NOT NULL,
	***IDAlumno 
	***IDDoc
	***IDMat
	Aula

)
