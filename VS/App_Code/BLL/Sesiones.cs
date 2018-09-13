using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Sesiones
/// </summary>
namespace BLL
{
    public class Sesiones
    {
        public Sesiones()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
        public static long InsertSesion(SesionesInfo info)
        {
            Sesion sesion = new Sesion();

            sesion.IDSesion = info.IDSesion;
            sesion.Fecha = info.Fecha;
            sesion.IDAlumno = info.IDAlumno;
            sesion.IDDoc = info.IDDoc;
            sesion.IDMat = info.IDMat;
            sesion.Aula = info.Aula;

            DataClassesDataContext dc = new DataClassesDataContext();

            dc.Sesion.InsertOnSubmit(sesion);
            dc.SubmitChanges();

            return sesion.IDSesion;
        }
    }
    public class SesionesInfo
    {
        public long IDSesion { get; set; }
        public DateTime Fecha { get; set; }
        public long IDAlumno { get; set; }
        public long IDDoc { get; set; }
        public long IDMat { get; set; }
        public string Aula { get; set; }
    }
}