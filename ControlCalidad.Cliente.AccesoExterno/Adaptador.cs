using ControlCalidad.Servidor.Servicio;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.AccesoExterno
{
    public class Adaptador
    {
        public static LineaDto[] GetLineas()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            
                return servicio.GetLineas();
            
        }

        public static UsuarioDto Autenticar(string usuario, string contrasenia)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.Autenticar(usuario, contrasenia);
            }
                
        }
        
        public static UsuarioDto[] UsuariosDisponibles()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.UsuariosDisponibles();
            }
                
        } 

        public static LineaDto[] GetLineasDisponibles()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetLineasDisponibles();
            }
                
        } 
        public static ModeloDto[] GetModelos()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetModelos();
            }
                
        } 
        public static ColorDto[] GetColores()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetColores();
            }
                
        } 
        
        public static DefectoDto[] GetDefectos()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetDefectos();
            }
                
        } 

        public static void crearNuevaOP(OrdenDeProduccionDto nuevaOP)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                servicio.CrearNuevaOP(nuevaOP);
            }
        }
        
        public static TurnoDto ObtenerTurno()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ObtenerTurno();
            }
        }
        public static bool CambiarEstadoOP(int NumeroOP,string Estado)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.CambiarEstadoOP(NumeroOP,Estado);
            }
        }
        
    }
}
