using ControlCalidad.Cliente.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentador
{
    public class AutenticacionPresentador2
    {
        IAutenticacion2 autenticacionVista;
        public AutenticacionPresentador2(IAutenticacion2 vista)
        {
            autenticacionVista = vista;
        }

        public void Autenticar()
        {

        }
    }

}
