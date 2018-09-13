using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Docentes
/// </summary>
namespace BLL
{
    public class Docentes
    {
        public Docentes()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }   
        public static long InsertDocente(DocentesInfo  info)
        {
            Docente Docente = new Docente();

            Docente.IDDoc = info.IDDoc;
            Docente.RFC = info.RFC;
            Docente.DNombre = info.DNombre;
            Docente.DApPaterno = info.DApPaterno;
            Docente.DApMaterno = info.DApMaterno;

            DataClassesDataContext dc = new DataClassesDataContext();

            dc.Docente.InsertOnSubmit(Docente);
            dc.SubmitChanges();

            return Docente.IDDoc;
        }
    }
    public class DocentesInfo
    {
        public long IDDoc { get; set; }
        public string RFC { get; set; }
        public string DNombre { get; set; }
        public string DApPaterno { get; set; }
        public string DApMaterno { get; set; }
    }
}