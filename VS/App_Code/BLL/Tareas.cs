using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de Tareas
/// </summary>
namespace BLL
{
    public class Tareas
    {
        public Tareas()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
    public class TareasInfo
    {
        public long IDTareas { get; set; }
        public long IDMat { get; set; }
        public string Titulo { get; set; }
        ///public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}