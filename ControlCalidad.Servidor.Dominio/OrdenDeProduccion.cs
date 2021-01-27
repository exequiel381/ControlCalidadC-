using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class OrdenDeProduccion
    {
        public int Numero { get; set; }
        public string Estado { get; set;}

        public Linea lineaAsignada { get; set;}
    
        public Usuario SupLineaAsignado { get; set;}

        public Usuario SupCalidadAsignado { get; set;}

        public Color Color { get; set; }
        public Modelo modelo { get; set; }
       
    }
}
