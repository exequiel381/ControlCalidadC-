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

        public static void GuardarDatosHermanado(int numeroOP, int primera, int segunda)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                servicio.GuardarDatosHermanado(numeroOP,primera,segunda);
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

        public static string ObtenerPromerdioParesPorHora(int nop)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ObtenerPromerdioParesPorHora(nop);
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

        public static void RegistrarHallazgo(int NumeroOP,HallazgoDto hallazgo)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                servicio.RegistrarHallazgo(NumeroOP, hallazgo);
            }
        }

        public static int ContabilizarDefecto(string pie, int idDefecto, int NumeroOP)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ContabilizarDefecto(pie, idDefecto, NumeroOP);
            }
        }

        public static void RegistrarParPrimera(string primera, int hora, int Valor, int NumeroOP)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                servicio.RegistrarParPrimera(primera, hora, Valor, NumeroOP);
            }
        }

        public static int ObtenerCantidadPrimera(int NumeroOP)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ObtenerCantidadPrimera(NumeroOP);
            }
        }
    }
}
