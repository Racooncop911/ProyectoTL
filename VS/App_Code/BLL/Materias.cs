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
    public static long InsertMaterias(MateriasInfo info)
        {
            Materia Materia = new Materia();

            Materia.IDMat = info.IDMat;
            Materia.Clave = info.Clave;
            Materia.Creditos = info.Creditos;
            Materia.Nombre = info.Nombre;

            DataClassesDataContext dc = new DataClassesDataContext();
            dc.Materia.InsertOnSubmit(Materia);
            dc.SubmitChanges();

            return Materia.IDMat;
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