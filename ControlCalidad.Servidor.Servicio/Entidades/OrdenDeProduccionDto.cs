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
    public class OrdenDeProduccionDto
    {
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]

        public LineaDto lineaAsignada { get; set; }
        [DataMember]
        public UsuarioDto SupLineaAsignado { get; set; }
        [DataMember]
        public UsuarioDto SupCalidadAsignado { get; set; }

        [DataMember]
        public ModeloDto Modelo { get; set; }
        [DataMember]
        public ColorDto Color { get; set; }
      


    }
}
