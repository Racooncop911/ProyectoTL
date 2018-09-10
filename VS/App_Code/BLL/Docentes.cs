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