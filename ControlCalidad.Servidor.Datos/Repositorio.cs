using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Datos
{
    public class Repositorio
    {
        // Singleton
        private static Repositorio miRepositorio;
        public static Repositorio getRepositorio()
        { 

            if (miRepositorio == null)
            {
                miRepositorio = new Repositorio();
            }
            return miRepositorio;
        }

        
        public List<Linea> lineas = new List<Linea>();
        public List<OrdenDeProduccion> ordenes = new List<OrdenDeProduccion>();
        public List<Modelo> modelos = new List<Modelo>();
        public List<Color> colores = new List<Color>();
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Turno> turnos = new List<Turno>();
        public List<Defecto> defectos = new List<Defecto>();


        Usuario usuario1 = new Usuario { Nombre = "carlos", Dni = 1, usuario = "supervisorLineaLibre", contrasenia = "", rol = Rol.SupervisorDeLinea.ToString() };
        Usuario usuario2 = new Usuario { Nombre = "juan", Dni = 2, usuario = "supervisorLineaOcupado", contrasenia = "", rol = Rol.SupervisorDeLinea.ToString() };
        Usuario usuario3 = new Usuario { Nombre = "sebas", Dni = 3, usuario = "supervisorCalidadLibre", contrasenia = "", rol = Rol.SupervisorDeCalidad.ToString() };
        Usuario usuario4 = new Usuario { Nombre = "jorge", Dni = 4, usuario = "supervisorCalidadOcupado", contrasenia = "", rol = Rol.SupervisorDeCalidad.ToString() };


        Linea linea1 = new Linea { Numero = 1 };
        Linea linea2 = new Linea { Numero = 2 };
        Linea linea3 = new Linea { Numero = 3 };

        Modelo modelo1 = new Modelo { Sku = "1", Denominacion = "Modelo1", Objetivo = 60 };
        Modelo modelo2 = new Modelo { Sku = "2", Denominacion = "Modelo2", Objetivo = 100 };
        Modelo modelo3 = new Modelo { Sku = "3", Denominacion = "Modelo3", Objetivo = 120 };

        Color color1 = new Color { Codigo = 1, Descripcion = "rojo" }; 
        Color color2 = new Color { Codigo = 2, Descripcion = "azul" };

        DateTime inicio1 = new DateTime(2020, 05, 05, 8, 00, 00);
        DateTime inicio2 = new DateTime(2020, 05, 05, 13, 00, 00);
        DateTime fin1 = new DateTime(2020, 05, 05, 12, 00, 00);
        DateTime fin2 = new DateTime(2020, 05, 05, 00, 00, 00);

        Defecto d1 = new Defecto { idDefecto=1 , Detalle="Despegado" , tipoDefecto = TipoDefecto.Observado.ToString()};
        Defecto d2 = new Defecto { idDefecto=2 , Detalle="Manchado", tipoDefecto = TipoDefecto.Observado.ToString()};
        Defecto d3 = new Defecto { idDefecto=3 , Detalle="Descocido" , tipoDefecto = TipoDefecto.Observado.ToString()};
        Defecto d4 = new Defecto { idDefecto=4 , Detalle="Descolorido" , tipoDefecto = TipoDefecto.Reproceso.ToString()};
        Defecto d5 = new Defecto { idDefecto=5 , Detalle="Despegado" , tipoDefecto = TipoDefecto.Reproceso.ToString()};
        Defecto d6 = new Defecto { idDefecto=6 , Detalle="Partido" , tipoDefecto = TipoDefecto.Reproceso.ToString()};
       
        
        

        private Repositorio()
        {

            Turno mañana = new Turno(inicio1,fin1);
            mañana.Descripcion = "Mañana";
            Turno tarde = new Turno(inicio2,fin2);
            tarde.Descripcion = "Tarde";

            turnos.Add(mañana);
            turnos.Add(tarde);


            lineas.Add(linea1);
            lineas.Add(linea2);
            lineas.Add(linea3);

            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            usuarios.Add(usuario3);
            usuarios.Add(usuario4);

            OrdenDeProduccion op1 = new OrdenDeProduccion { Numero = 100, Estado = EstadoOP.Proceso.ToString(), lineaAsignada = linea1, SupLineaAsignado = usuario2, SupCalidadAsignado = usuario4 , Color = color1, modelo = modelo1};
            OrdenDeProduccion op2 = new OrdenDeProduccion { Numero = 200, Estado = EstadoOP.Finalizada.ToString(), lineaAsignada = linea2, SupLineaAsignado = usuario2, SupCalidadAsignado = usuario3, Color = color1, modelo = modelo1 };
            OrdenDeProduccion op3 = new OrdenDeProduccion { Numero = 300, Estado = EstadoOP.Finalizada.ToString(), lineaAsignada = linea1, SupLineaAsignado = usuario1, SupCalidadAsignado = usuario3, Color = color1, modelo = modelo1 };

            ordenes.Add(op1);
            ordenes.Add(op2);
            ordenes.Add(op3);

            usuario1.OrdenesAsignadas.Add(op3);
            usuario2.OrdenesAsignadas.Add(op1);
            usuario2.OrdenesAsignadas.Add(op2);
            usuario3.OrdenesAsignadas.Add(op2);
            usuario3.OrdenesAsignadas.Add(op3);
            usuario4.OrdenesAsignadas.Add(op1);

            modelos.Add(modelo1);
            modelos.Add(modelo2);
            modelos.Add(modelo3);

            colores.Add(color1);
            colores.Add(color2);

            defectos.Add(d1);
            defectos.Add(d2);
            defectos.Add(d3);
            defectos.Add(d4);
            defectos.Add(d5);
            defectos.Add(d6);


        }

        public Usuario AutenticarUsuario(string usuario, string contrasenia)
        {
           
            foreach(var u in usuarios)
            {
                if (u.usuario.Equals(usuario) && u.contrasenia.Equals(contrasenia)) return u;
            }

            return null;

        }

        public bool CambiarEstadoOP(int NumeroOP, string Estado)
        {
            foreach (OrdenDeProduccion op in ordenes)
            {
                if (op.Numero == NumeroOP)
                {
                    op.Estado = Estado;
                    return true;

                }
            }
            return false;
        }

        public static IEnumerable<Linea> GetLineas()
        {
            return getRepositorio().lineas;
        }

        public static IEnumerable<Usuario> GetUsuarios()
        {
            return getRepositorio().usuarios;
        }
        public static IEnumerable<OrdenDeProduccion> GetOrdenes()
        {
            return getRepositorio().ordenes;
        }
        
        public static IEnumerable<Modelo> GetModelos()
        {
            return getRepositorio().modelos;
        }
        public static IEnumerable<Color> GetColores()
        {
            return getRepositorio().colores;
        }

        public static IEnumerable<Turno> GetTurnos()
        {
            return getRepositorio().turnos;
        }

        public IEnumerable<Defecto> GetDefectos()
        {
            return getRepositorio().defectos;
        }
    }
}
