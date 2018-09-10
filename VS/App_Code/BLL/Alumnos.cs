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
    }
    public class AlumnosInfo
    {
        public long IDAlumno { get; set; }
        public long NoControl { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Carrera { get; set; }
        public long Telefono { get; set; }
        public string Correo { get; set; }
    }
}