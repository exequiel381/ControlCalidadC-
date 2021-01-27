using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Entidades
{
    [DataContract]
    public class UsuarioDto
    {
        [DataMember]
        public int Dni { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string contrasenia { get; set; }
        [DataMember]
        public string rol { get; set; }
        [DataMember]
        public List<OrdenDeProduccionDto> OrdenesAsignadas { get; set; }
        [DataMember]
        public int? NumeroOpAsignada { get; set; }
        [DataMember]
        public int? NumeroDeLineaOcupada { get; set; }
        [DataMember]
        public OrdenDeProduccionDto opActual { get; set; }


        public UsuarioDto()
        {
            OrdenesAsignadas = new List<OrdenDeProduccionDto>();
        }

        
    }
}
