using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Hallazgo
    {
        public int hora { get; set; }
        public string pie { get; set; }
        public Defecto defecto { get; set; }
        public int Valor { get; set; }

        public string ParDePrimera { get; set; }
    }
}
