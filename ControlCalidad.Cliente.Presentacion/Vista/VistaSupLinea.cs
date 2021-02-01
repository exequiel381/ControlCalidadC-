using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentador;
using ControlCalidad.Servidor.Servicio;
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
    public partial class VistaSupLinea : Form , IOrdenDeProduccion
    {
        UsuarioDto supervisorLinea;
        OrdenDeProduccionDto OpActual;

        public VistaSupLinea(UsuarioDto supervisorLineaActual)
        {
            this.supervisorLinea = supervisorLineaActual;
            
            InitializeComponent();

        }

        
        private void VistaSupLinea_Load(object sender, EventArgs e)
        {

        }

        public int NumeroOP
        {
            get { return int.Parse(lbNOP.Text); }
            set { lbNOP.Text = "" + value; }
        }
        public UsuarioDto SupervisorLineaAsignado
        {

            get { return supervisorLinea; }
            set { supervisorLinea = value; }
        }

        public LineaDto Linea {
            get {
                return new LineaDto { Numero = int.Parse(lbLineaOP.Text)};
            }

            set {
                lbLineaOP.Text = ""+value;
            } 
            
         }
        public UsuarioDto SupervisorCalidadAsignado
        {

            get { return null; }
            set {  }
        }

        public ModeloDto modelo
        {

            get { return null; }
            set {  }
        }

        public ColorDto color
        {
            get { return null; }
            set {  }
        }


        public void rellenarCampos(OrdenDeProduccionDto op)//int nOP, string estado, int linea)
        {
            this.OpActual = op;
            lbNOP.Text = ""+op.Numero;
            lbEstado.Text = op.Estado;
            lbLineaOP.Text = "" + op.lineaAsignada.Numero;
            lbColor.Text = op.Color.Descripcion;
            lbModelo.Text = op.Modelo.Denominacion;
            lbObjetivo.Text = ""+op.Modelo.Objetivo;

            if (op.Estado.Equals("Proceso")) btnReanudar.Enabled = false;
            if (op.Estado.Equals("Pausada")) btnPausar.Enabled = false;
        }

        public void OcultarPanelOP()
        {
          PanelOP.Visible = false;
          
        }

        public void OcultarPanelNuevaOP()
        {
            PanelNuevaOP.Visible = false;

        }

        private void btnCrearOP_Click(object sender, EventArgs e)
        {
            OrdenDeProduccionPresentador opPresentador = new OrdenDeProduccionPresentador(this);
            
            //AQUI BUSCAR EL TURNO Y SI ES NULO NO PODEMOS CREAR
            opPresentador.MostrarCrearNuevaOP(supervisorLinea);
            this.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            OrdenDeProduccionPresentador opPresentador = new OrdenDeProduccionPresentador(this);
            bool cambioDeEstado = opPresentador.CambiarEstadoOP(int.Parse(lbNOP.Text),"Pausada");
            if(cambioDeEstado) this.lbEstado.Text = "Pausada";
            btnReanudar.Enabled = true;

           
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            OrdenDeProduccionPresentador opPresentador = new OrdenDeProduccionPresentador(this);
            bool cambioDeEstado = opPresentador.CambiarEstadoOP(int.Parse(lbNOP.Text), "Proceso");
            if (cambioDeEstado) this.lbEstado.Text = "Proceso";

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿Esta seguro de finalizar la Orden de produccion Actual ?", "FinalizarOP", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OrdenDeProduccionPresentador opPresentador = new OrdenDeProduccionPresentador(this);
                bool cambioDeEstado = opPresentador.CambiarEstadoOP(int.Parse(lbNOP.Text), "Finalizada");
                if (cambioDeEstado)
                {
                    this.lbEstado.Text = "Finalizada";
                    MessageBox.Show("Orden Finalizada");
                }

                this.OcultarPanelOP();
                PanelNuevaOP.Visible = true;


            }


            

            
        }

        private void btnDatosEnLinea_Click(object sender, EventArgs e)
        {
            OrdenDeProduccionPresentador opPresentador = new OrdenDeProduccionPresentador(this);
            opPresentador.MostrarDatosEnLinea(OpActual,supervisorLinea);
        }
    }
}
