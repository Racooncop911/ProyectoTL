using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Periodos
/// </summary>
namespace BLL
{
    public class Periodos
    {
        public Periodos()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
    public class PeriodosInfo
    {
        public long IDPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
    }
}