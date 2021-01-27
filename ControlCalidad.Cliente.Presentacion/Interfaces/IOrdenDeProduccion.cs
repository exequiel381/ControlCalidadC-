using ControlCalidad.Servidor.Servicio;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IOrdenDeProduccion
    {
        LineaDto Linea  { get; set; }
        int NumeroOP { get; set; }
        UsuarioDto SupervisorLineaAsignado { get; set; }
        UsuarioDto SupervisorCalidadAsignado { get; set; }

        ModeloDto modelo { get; set; }

        ColorDto color { get; set; }


        
    }
}
