using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Usuario
    {
        
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }

        public string rol { get; set; }
        public List<OrdenDeProduccion> OrdenesAsignadas { get; set; }

        public Usuario(){
            OrdenesAsignadas = new List<OrdenDeProduccion>();
        }

        public OrdenDeProduccion verificarDisponibilidadUsuario()
        {
            foreach(OrdenDeProduccion op in OrdenesAsignadas)
            {
                if (op.Estado.Equals("Proceso")) return op;
            }

            return null;
        }

        public OrdenDeProduccion crearNuevaOP(Usuario supLineaAsig, Usuario supCalAsig, int num, Linea l, Modelo m,Color c)
        {
            return new OrdenDeProduccion
            {
                Numero = num,
                Estado = EstadoOP.Proceso.ToString(),
                SupCalidadAsignado = supCalAsig,
                SupLineaAsignado = this,
                lineaAsignada = l,
                modelo = m,
                Color = c

            };
        }
        

        

}
}
