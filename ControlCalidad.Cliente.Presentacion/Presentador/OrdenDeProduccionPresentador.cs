using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Vista;
using ControlCalidad.Cliente.Presentador;
using ControlCalidad.Servidor.Servicio;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Presentador
{
    public class OrdenDeProduccionPresentador
    {
        IOrdenDeProduccion OPvista;

        public OrdenDeProduccionPresentador(IOrdenDeProduccion vista)
        {
           OPvista = vista;
        }

        public void MostrarCrearNuevaOP(UsuarioDto supervisorLineaActual)
        {

            if (this.ObtenerTurno() != null)
            {

            nuevaOP ventanaNuevaOp = new nuevaOP(supervisorLineaActual);
            ventanaNuevaOp.RellenarCampos(Adaptador.UsuariosDisponibles(), Adaptador.GetLineasDisponibles(), Adaptador.GetModelos(), Adaptador.GetColores()) ;
            ventanaNuevaOp.Show();

            }
            else MessageBox.Show("Usted esta fuera del horario de trabajo");

        }

        public void CrearNuevaOP()//int Numero, ColorDto color, ModeloDto modelo, LineaDto linea, UsuarioDto supervisorCalidad, UsuarioDto supervisorLinea )
        {
            
                OrdenDeProduccionDto nuevaOP = new OrdenDeProduccionDto();
                nuevaOP.Numero = OPvista.NumeroOP;
                nuevaOP.Color = OPvista.color;
                nuevaOP.Modelo = OPvista.modelo;
                nuevaOP.Estado = "Proceso";
                nuevaOP.SupCalidadAsignado = OPvista.SupervisorCalidadAsignado;
                nuevaOP.SupLineaAsignado = OPvista.SupervisorLineaAsignado;
                nuevaOP.lineaAsignada = OPvista.Linea;

                Adaptador.crearNuevaOP(nuevaOP);

                VistaSupLinea SL = new VistaSupLinea(OPvista.SupervisorLineaAsignado);
                SL.OcultarPanelNuevaOP();//Ocultar panel de crear OP, y mostramos la OP.
                SL.rellenarCampos(nuevaOP);
                SL.Show();

        }

        public bool CambiarEstadoOP(int NumeroOP,string Estado)
        {
            if (this.ObtenerTurno()!=null)
            {
                return Adaptador.CambiarEstadoOP(NumeroOP, Estado);
            }
            else
            {
                MessageBox.Show("No se puedo actualizar el Estado, Esta fuera del turno de Trabajo");
                return false;
            }
        }

        public TurnoDto ObtenerTurno()
        {
            return Adaptador.ObtenerTurno();
        }

        public void ComenzarInspeccion(OrdenDeProduccionDto op, UsuarioDto supervisorCalidadActual)
        {
            //TRAEMOS EL TURNO EN QUE SE ENCUENTRA
            TurnoDto t = this.ObtenerTurno();

            //TRAEMOS UN ARRAY DE DEFECTOS DTO Y LO HACEMOS UNA LISTA
            List<DefectoDto> ddto = new List<DefectoDto>();
            foreach(DefectoDto d in Adaptador.GetDefectos())
            {
                ddto.Add(new DefectoDto {

                    IdDefecto = d.IdDefecto,
                    Detalle = d.Detalle,
                    TipoDefecto = d.TipoDefecto

                });
            }
            
            
            if (t != null)
            {
                //OBTENEMOS DOS LISTAS, UNA DE DEFECTOS REPROCESO Y OTRA DE OBSERVADOS
                List<DefectoDto> observados = ddto.FindAll(
                    delegate (DefectoDto dO) {
                        return dO.TipoDefecto == "Observado";
                    });

                List<DefectoDto> reproceso = ddto.FindAll(
                    delegate (DefectoDto dr) {
                        return dr.TipoDefecto == "Reproceso";
                    });


                VistaInspeccion vi = new VistaInspeccion(op,supervisorCalidadActual,observados,reproceso,t);
                vi.RellenarCamposyTablas();
                vi.Show();
            }
            else MessageBox.Show("No se puede Comenzar una INSPECCION. Esta fuera del turno de Trabajo");


        }

        public void MostrarDatosEnLinea(OrdenDeProduccionDto op , UsuarioDto supLinea)
        {
            TurnoDto t = this.ObtenerTurno();
            if (t != null)
            {
                
                //TRAEMOS UN ARRAY DE DEFECTOS DTO Y LO HACEMOS UNA LISTA
                List<DefectoDto> ddto = new List<DefectoDto>();
                foreach (DefectoDto d in Adaptador.GetDefectos())
                {
                    ddto.Add(new DefectoDto
                    {

                        IdDefecto = d.IdDefecto,
                        Detalle = d.Detalle,
                        TipoDefecto = d.TipoDefecto

                    });
                }

                //OBTENEMOS DOS LISTAS, UNA DE DEFECTOS REPROCESO Y OTRA DE OBSERVADOS
                List<DefectoDto> observados = ddto.FindAll(
                    delegate (DefectoDto dO) {
                        return dO.TipoDefecto == "Observado";
                    });

                List<DefectoDto> reproceso = ddto.FindAll(
                    delegate (DefectoDto dr) {
                        return dr.TipoDefecto == "Reproceso";
                    });

                DatosEnLinea vistaDatosEnLinea = new DatosEnLinea(op, supLinea,observados,reproceso,t);
                vistaDatosEnLinea.RellenarCamposyTablas();
                vistaDatosEnLinea.Show();


            }
            else
            {
                MessageBox.Show("No se puedo ver datos en linea, Esta fuera del turno de Trabajo");
               
            }
        }
    }
}
