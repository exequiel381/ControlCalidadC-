using ControlCalidad.Cliente.Presentacion.Presentador;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vista
{
    public partial class DatosEnLinea : Form
    {
        OrdenDeProduccionDto op;
        UsuarioDto supervisorLinea;
        List<DefectoDto> observados;
        List<DefectoDto> Reproceso;
        TurnoDto t;
        InspeccionPresentador inspeccionPresentador;


        public DatosEnLinea(OrdenDeProduccionDto op, UsuarioDto supervisorLinea, List<DefectoDto> observados, List<DefectoDto> Reproceso, TurnoDto t)
        {
            this.op = op;
            this.supervisorLinea = supervisorLinea;
            this.observados = observados;
            this.Reproceso = Reproceso;
            this.t = t;
            inspeccionPresentador = new InspeccionPresentador(op);
            InitializeComponent();
        }

        private void DatosEnLinea_Load(object sender, EventArgs e)
        {

        }

        public void RellenarCamposyTablas()
        {
            lbUsuario.Text = supervisorLinea.usuario;
            lbTurno.Text = t.Descripcion;
            lbNOP.Text = "" + op.Numero;
            lbLinea.Text = "" + op.lineaAsignada.Numero;
         
            //Damos el ancho de las columnas y le cargamos los defectos

            IzqObservado.Columns[0].Width = 40;
            IzqObservado.Columns[1].Width = 100;
            IzqObservado.Columns[2].Width = 60;

            
            IzqReproceso.Columns[0].Width = 40;
            IzqReproceso.Columns[1].Width = 100;
            IzqReproceso.Columns[2].Width = 60;

            DerObservado.Columns[0].Width = 40;
            DerObservado.Columns[1].Width = 100;
            DerObservado.Columns[2].Width = 60;

            DerReproceso.Columns[0].Width = 40;
            DerReproceso.Columns[1].Width = 100;
            DerReproceso.Columns[2].Width = 60;


            foreach (DefectoDto d in Reproceso)
            {
                DerReproceso.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Derecho", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 
            }
            foreach (DefectoDto d in observados)
            {
                DerObservado.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Derecho", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 
            }
            foreach (DefectoDto d in Reproceso)
            {
                IzqReproceso.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Izquierdo", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 
            }
            foreach (DefectoDto d in observados)
            {
                IzqObservado.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Izquierdo", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 

            }

            lbParesDePrimera.Text = "" + inspeccionPresentador.ObtenerCantidadPrimera(op.Numero);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzqObservado.Rows.Clear();
            IzqReproceso.Rows.Clear();
            DerObservado.Rows.Clear();
            DerReproceso.Rows.Clear();
            this.RellenarCamposyTablas();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
