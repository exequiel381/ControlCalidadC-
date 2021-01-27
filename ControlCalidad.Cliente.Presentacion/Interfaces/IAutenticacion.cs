using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Vistas
{
    public interface IAutenticacion

    {
        string usuario { get; set; }
        string contrasenia { get; set; }
    }
}
