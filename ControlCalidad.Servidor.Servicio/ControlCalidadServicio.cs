using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Servicio.Controladores;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace ControlCalidad.Servidor.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ControlCalidadServicio : IControlCalidadServicio
    {
        private OrdenDeProduccionControlador _controladorOP = new OrdenDeProduccionControlador(); 
        private InspeccionControlador _controladorInspeccion = new InspeccionControlador(); 
        public LineaDto[] GetLineas()
        {
            return Repositorio.GetLineas()
                .Select(l => new LineaDto
                {
                    Numero = l.Numero,
                    Descripcion = l.Descripcion
                })
                .ToArray();
        }

        public UsuarioDto Autenticar(string usuario, string contrasenia)
        {
            
            OrdenDeProduccionDto OPActual = null;
            var user = Repositorio.getRepositorio().AutenticarUsuario(usuario, contrasenia);


            if (user != null)

            {
                if(user.verificarDisponibilidadUsuario() != null)
                {

                

                OPActual = new OrdenDeProduccionDto {
                    Numero = user.verificarDisponibilidadUsuario().Numero,
                    Estado = user.verificarDisponibilidadUsuario().Estado,
                    lineaAsignada = new LineaDto { Numero = user.verificarDisponibilidadUsuario().lineaAsignada.Numero },
                    Color = new ColorDto { Codigo = user.verificarDisponibilidadUsuario().Color.Codigo , Descripcion = user.verificarDisponibilidadUsuario().modelo.Denominacion },
                    Modelo = new ModeloDto { Sku = user.verificarDisponibilidadUsuario().modelo.Sku, Denominacion = user.verificarDisponibilidadUsuario().modelo.Denominacion, Objetivo = user.verificarDisponibilidadUsuario().modelo.Objetivo }

                };

                }

                return new UsuarioDto
                {
                    Dni = user.Dni,
                    Nombre = user.Nombre,
                    usuario = user.usuario,
                    rol = user.rol,
                    opActual = OPActual

                };
            }

            return null;
        }

        public UsuarioDto[] UsuariosDisponibles()
        {
           

            List<Usuario> supervisoresCalidadDisponibles2 = new List<Usuario>();
            List<Usuario> supervisoresCalidadOcupados = new List<Usuario>();

            foreach (Usuario u in Repositorio.GetUsuarios())
            {
                foreach (OrdenDeProduccion op in Repositorio.GetOrdenes())
                {
                    if (op.Estado.Equals("Proceso") && op.SupCalidadAsignado.Dni==u.Dni)
                    {
                        supervisoresCalidadOcupados.Add(u);
                    }
                }
            }

            foreach (Usuario u in Repositorio.GetUsuarios())
            {
                if(supervisoresCalidadOcupados.Exists(x => x.Dni == u.Dni) == false && u.rol.Equals(Rol.SupervisorDeCalidad.ToString()))//COMPROBAMOS QUE NO EXISTE EL USUARIO EN LOS OCUPADOS
                {
                    supervisoresCalidadDisponibles2.Add(u);
                }
            }

            UsuarioDto[] supervisoresCalidadDisponibles = supervisoresCalidadDisponibles2
               .Select(l => new UsuarioDto
               {
                   usuario = l.usuario,
                   Dni = l.Dni,
                   Nombre = l.Nombre,
                   rol = l.rol

               })
               .ToArray();


            return supervisoresCalidadDisponibles;
        }

        public LineaDto[] GetLineasDisponibles()
        {
            List<Linea> LineasDisponibles = new List<Linea>();
            List<Linea> LineasOcupadas = new List<Linea>();

            
                foreach (OrdenDeProduccion op in Repositorio.GetOrdenes())
                {
                    if (op.Estado.Equals("Proceso"))
                    {
                       LineasOcupadas.Add(op.lineaAsignada);
                    }
                }
            

            foreach (Linea l in Repositorio.GetLineas())
            {
                if (LineasOcupadas.Exists(x => x.Numero == l.Numero) == false)//COMPROBAMOS QUE NO EXISTE EL USUARIO EN LOS OCUPADOS
                {
                    LineasDisponibles.Add(l);
                }
            }

            return LineasDisponibles
                .Select(l => new LineaDto
                {
                    Numero = l.Numero,
                   
                })
                .ToArray();
        }

        public ModeloDto[] GetModelos()
        {
            return Repositorio.GetModelos()
                .Select(l => new ModeloDto
                {
                    Sku = l.Sku,
                    Denominacion = l.Denominacion,
                    Objetivo = l.Objetivo
                })
                .ToArray();
        }
        public ColorDto[] GetColores()
        {
            return Repositorio.GetColores()
               .Select(l => new ColorDto
               {
                   Codigo = l.Codigo,
                   Descripcion = l.Descripcion
               })
               .ToArray();
        }

        public void CrearNuevaOP(OrdenDeProduccionDto nuevaOP)
        {
            _controladorOP.CrearNuevaOP(nuevaOP);
        }

        public TurnoDto ObtenerTurno()
        {
            Turno t = _controladorOP.ObtenerTurnoActual();
            

            if (t == null)
            {
                return null;
            }
            else
            {

            return new TurnoDto
            {
                Inicio = t.Inicio,
                Fin = t.Fin,
                Descripcion = t.Descripcion,
                horasDelTurno = t.GetHorasHabilitadasParaTrabajarPosterioresAlaActual(),
                
            };
            }

        }

        public DefectoDto[] GetDefectos()
        {
            
            return Repositorio.getRepositorio().GetDefectos().Select(d => new DefectoDto
            {
                IdDefecto = d.idDefecto,
                Detalle = d.Detalle,
                TipoDefecto = d.tipoDefecto
            })
               .ToArray();

        }

        public bool CambiarEstadoOP(int NumeroOP, string Estado)
        {
            return _controladorOP.CambiarEstadoOP(NumeroOP, Estado);

        }

        public void RegistrarHallazgo(int NumeroOP, HallazgoDto hallazgo)
        {

            Hallazgo h = new Hallazgo
            {
                defecto = new Defecto
                {
                    idDefecto = hallazgo.defecto.IdDefecto,
                    Detalle = hallazgo.defecto.Detalle,
                    tipoDefecto = hallazgo.defecto.TipoDefecto


                },

                hora = hallazgo.hora,
                pie = hallazgo.pie,
                Valor = hallazgo.Valor,
            };

            _controladorInspeccion.RegistrarHallazgo(NumeroOP,h);
        }

        public int ContabilizarDefecto(string pie, int idDefecto, int NumeroOP)
        {
            return _controladorInspeccion.ContabilizarDefecto(pie, idDefecto, NumeroOP);
        }

        public int ObtenerCantidadPrimera(int NumeroOP)
        {
            return _controladorInspeccion.ObtenerCantidadPrimera(NumeroOP);
        }

        public void RegistrarParPrimera(int Valor, int NumeroOP)
        {
            _controladorInspeccion.RegistrarParPrimera(Valor, NumeroOP);
        }
    }
 }
