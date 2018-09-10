using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;///USANDO LA CAEPETA DAL como referencia

/// <summary>
/// Descripción breve de Materias
/// </summary>
namespace BLL///utilizamos BLL en el nombre de espaico
{
    public class Materias
    {
        public Materias()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
    public class MateriasInfo
    {
        //
        ///public DateTime FCreacion { get; set; }
        public long IDMat { get; set; }
        public string Clave { get; set; }
        public int Creditos { get; set; }
        public string Nombre { get; set; }

        
    }
}