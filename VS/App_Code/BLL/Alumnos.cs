using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;///USANDO LA CAEPETA DAL como referencia

/// <summary>
/// Descripción breve de Alumnos
/// </summary>
namespace BLL
{
public class Alumnos
{
    public Alumnos()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public static long InsertAlumno(AlumnosInfo info)
    {
        Alumno Alumno = new Alumno();
        //Item.FechaCreacion = DateTime.Now;
        Alumno.IDAlumno = info.IDAlumno;
        Alumno.NoControl = info.NoControl;

        Alumno.Nombre = info.Nombre;
        Alumno.ApPaterno = info.ApPaterno;
        Alumno.ApMaterno = info.ApMaterno;

        Alumno.Carrera = info.Carrera;
        Alumno.Telefono = info.Telefono;
        Alumno.Correo = info.Correo;

        DataClassesDataContext dc = new DataClassesDataContext();

        dc.Alumno.InsertOnSubmit(Alumno);
        dc.SubmitChanges();

        return Alumno.IDAlumno;
    }
}
    
public class AlumnosInfo//plural
{
    public long IDAlumno { get; set; }
    public int NoControl { get; set; }
    public string Nombre { get; set; }
    public string ApPaterno { get; set; }
    public string ApMaterno { get; set; }
    public string Carrera { get; set; }
    public long Telefono { get; set; }
    public string Correo { get; set; }
}
}