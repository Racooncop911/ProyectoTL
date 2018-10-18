using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public long CreateAlumno(AlumnosInfo info)
        {
            //   long IDAlumno;
            // return IDAlumno;

            Alumno alumno = new Alumno();
            //Item.FechaCreacion = DateTime.Now;
            alumno.IDAlumno = info.IDAlumno;
            alumno.Nombre = info.Nombre;
            alumno.ApPaterno = info.ApPaterno;
            alumno.ApMaterno = info.ApMaterno;


            DataClassesDataContext dc = new DataClassesDataContext();

            dc.Alumno.InsertOnSubmit(alumno);
            
            dc.SubmitChanges();

            return alumno.IDAlumno;
        }
        //READ
        public List<AlumnosInfo> GetAlumnos()
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            var query =
                (
                from Alumno in dc.Alumno
                orderby Alumno.ApPaterno
                select new AlumnosInfo
                {
                    Nombre = Alumno.Nombre,
                    IDAlumno = Alumno.IDAlumno,
                });

            return query.ToList();
        }
        //UPDATE
        public void UpdateAlumno(AlumnosInfo info)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            Alumno alumno = dc.Alumno.SingleOrDefault(p => p.IDAlumno == info.IDAlumno);
            if (alumno != null)
            {
                alumno.Nombre = info.Nombre;
                alumno.ApMaterno = info.ApMaterno;
                alumno.ApPaterno = info.ApPaterno;
            }

        }

        //DELETE
        public void DeleteAlumno(long IDAlumno)
        {
            DataClassesDataContext dc = new DataClassesDataContext();
            Alumno alumno = dc.Alumno.SingleOrDefault(p => p.IDAlumno == IDAlumno);
            if (alumno != null)
            {
                dc.Alumno.DeleteOnSubmit(alumno);
                dc.SubmitChanges();
            }
        }



    }
    
}
