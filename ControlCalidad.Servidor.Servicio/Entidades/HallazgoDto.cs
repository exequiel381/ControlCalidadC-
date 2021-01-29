using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Entidades
{
    [DataContract]
    public class HallazgoDto
    {
        [DataMember]
        public int hora { get; set; }
        [DataMember]
        public string pie { get; set; }
        [DataMember]
        public DefectoDto defecto { get; set; }
        [DataMember]
        public int Valor { get; set; }

    }
}
