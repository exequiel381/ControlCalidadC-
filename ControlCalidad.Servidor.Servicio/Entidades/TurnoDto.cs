using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Entidades
{
    [DataContract]
    public class TurnoDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Inicio { get; set; }
        [DataMember]
        public DateTime Fin { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public List<int> horasDelTurno { get; set; }
    }
}
