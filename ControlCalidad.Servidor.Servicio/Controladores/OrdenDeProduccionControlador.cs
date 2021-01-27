using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    class OrdenDeProduccionControlador
    {
        Turno turnoActual;
        public OrdenDeProduccionControlador()
        {
            turnoActual = this.ObtenerTurnoActual();
        }

        public void CrearNuevaOP(OrdenDeProduccionDto nuevaOP)//LA DEBE CREAR EL USUARIO NO AQUI
        {

           
                Usuario SupCalidadAsignado = new Usuario
                {
                    Dni = nuevaOP.SupCalidadAsignado.Dni,
                    Nombre = nuevaOP.SupCalidadAsignado.Nombre,
                    usuario = nuevaOP.SupCalidadAsignado.usuario,
                    rol = Rol.SupervisorDeCalidad.ToString(),

                };

                Usuario SupLineaAsignado = new Usuario
                {
                    Dni = nuevaOP.SupLineaAsignado.Dni,
                    Nombre = nuevaOP.SupLineaAsignado.Nombre,
                    usuario = nuevaOP.SupLineaAsignado.usuario,
                    rol = Rol.SupervisorDeLinea.ToString(),

                };

                Linea l = new Linea
            {
                Numero = nuevaOP.lineaAsignada.Numero
            };

                Modelo m = new Modelo
            {
                Sku = nuevaOP.Modelo.Sku,
                Denominacion = nuevaOP.Modelo.Denominacion
            };

                Color c = new Color { Codigo=nuevaOP.Color.Codigo, Descripcion = nuevaOP.Color.Descripcion };
                
                OrdenDeProduccion op = SupLineaAsignado.crearNuevaOP(SupLineaAsignado,SupCalidadAsignado,nuevaOP.Numero,l,m,c);


                SupCalidadAsignado.OrdenesAsignadas.Add(op);
                SupLineaAsignado.OrdenesAsignadas.Add(op);

                Repositorio.getRepositorio().ordenes.Add(op);

                MessageBox.Show("Orden de produccion creada y asignada a sus supervisores");

            
        }

        public Turno ObtenerTurnoActual()
        {
            foreach (Turno t in Repositorio.getRepositorio().turnos)
            {
                if (t.SoyTurnoActual()) return t; 

            }

            return null;
        }

        public bool CambiarEstadoOP(int NumeroOP,string Estado)
        {
            
            return Repositorio.getRepositorio().CambiarEstadoOP(NumeroOP, Estado);
        }
    }
}
