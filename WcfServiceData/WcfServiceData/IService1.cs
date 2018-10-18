using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //INSERT
        [OperationContract]
        long CreateAlumno(AlumnosInfo info);

        //QUERY - CONSULTA
        [OperationContract]
        List<AlumnosInfo> GetAlumnos();
        // TODO: agregue aquí sus operaciones de servicio

        //DELETE
        [OperationContract]
        void DeleteAlumno(long IDAlumno);
        //UPDATE
        [OperationContract]
        void UpdateAlumno(AlumnosInfo info);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class AlumnosInfo//plural
    {
        [DataMember]
        public long IDAlumno { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ApPaterno { get; set; }
        [DataMember]
        public string ApMaterno { get; set; }

    }
}
