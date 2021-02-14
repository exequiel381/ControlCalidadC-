using ControlCalidad.Cliente.Presentacion.Interfaces;
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
    public partial class VistaInspeccion : Form
    {
        int Valor = 0;
        OrdenDeProduccionDto op;
        UsuarioDto supervisorCalidad;
        List<DefectoDto> observados; 
        List<DefectoDto> Reproceso;
        TurnoDto t;
        InspeccionPresentador inspeccionPresentador;
        List<IObservador> observadores = new List<IObservador>();
        

        public VistaInspeccion(OrdenDeProduccionDto op, UsuarioDto supervisorCalidad, List<DefectoDto> observados, List<DefectoDto> Reproceso, TurnoDto t)//List<int> horasTurno)
        {
            this.op = op;
            this.supervisorCalidad = supervisorCalidad;
            this.observados = observados;
            this.Reproceso = Reproceso;
            this.t = t;
            inspeccionPresentador = new InspeccionPresentador(op);
            InitializeComponent();
        }

        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
          
        }

        public void eliminarObservador(IObservador o)
        {
            observadores.Remove(o);
        }
        // ---------------------------------
        public void notificarObservadores()
        {
            // Enviar la notificación a cada observador a través de su propio método
            foreach (IObservador obj in observadores)
            {
                obj.observadoActualizado();
            }
        }


        private void VistaInspeccion_Load(object sender, EventArgs e)
        {
            //seteamos los botones para que sume por defecto
            btnSumar.BackColor = Color.Green;
            btnSumar.Size = new Size(100, 50);
            btnRestar.BackColor = Color.Red;
            btnRestar.Size = new Size(75, 40);
            this.Valor = 1;



        }

        public void RellenarCamposyTablas()
        {
            lbUsuario.Text = supervisorCalidad.usuario;
            lbTurno.Text = t.Descripcion;
            lbNOP.Text =""+ op.Numero;
            lbLinea.Text = ""+op.lineaAsignada.Numero;
            cbxHoras.DataSource = t.horasDelTurno;
            
           
            
            //Damos el ancho de las columnas y le cargamos los defectos
            
            foreach(DefectoDto d in observados)
            {
                IzqObservado.Rows.Add(d.IdDefecto,d.Detalle, inspeccionPresentador.ContabilizarDefecto("Izquierdo", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 

            }

            IzqObservado.Columns[0].Width = 40;
            IzqObservado.Columns[1].Width = 100;
            IzqObservado.Columns[2].Width = 60;

            foreach (DefectoDto d in Reproceso)
            {
                IzqReproceso.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Izquierdo", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 
            }
            IzqReproceso.Columns[0].Width = 40;
            IzqReproceso.Columns[1].Width = 100;
            IzqReproceso.Columns[2].Width = 60;

            foreach (DefectoDto d in observados)
            {
                DerObservado.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Derecho", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 
            }
            DerObservado.Columns[0].Width = 40;
            DerObservado.Columns[1].Width = 100;
            DerObservado.Columns[2].Width = 60;

            foreach (DefectoDto d in Reproceso)
            {
                DerReproceso.Rows.Add(d.IdDefecto, d.Detalle, inspeccionPresentador.ContabilizarDefecto("Derecho", d.IdDefecto, op.Numero));//El tercer parametro sera la cantidad contada desde un metodo 
            }
            DerReproceso.Columns[0].Width = 40;
            DerReproceso.Columns[1].Width = 100;
            DerReproceso.Columns[2].Width = 60;

            lbParesDePrimera.Text = "" + inspeccionPresentador.ObtenerCantidadPrimera(op.Numero);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            btnSumar.BackColor = Color.Green;
            btnSumar.Size = new Size(100, 50);
            btnRestar.BackColor = Color.Red;
            btnRestar.Size = new Size(75, 40);
            this.Valor = 1;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            btnSumar.BackColor = Color.Red;
            btnSumar.Size = new Size(75, 40);
            btnRestar.BackColor = Color.Green;
            btnRestar.Size = new Size(100, 50);
            this.Valor = -1;
        }


        private void ActualizarContador(DataGridView tabla,string pie)
        {
            int cantidadActual = int.Parse(tabla.Rows[tabla.CurrentRow.Index].Cells[2].Value.ToString());
            if(cantidadActual == 0 && Valor < 0)
            {
                //mostraremos un mensaje en un label para no entorpecer
            }
            else
            {
                //podemos actualizarlo en la vista asi
                int idDefecto = int.Parse(tabla.Rows[tabla.CurrentRow.Index].Cells[0].Value.ToString());
                inspeccionPresentador.RegistrarHallazgo(pie, int.Parse(cbxHoras.SelectedItem.ToString()), idDefecto, Valor);

                //tabla.Rows[tabla.CurrentRow.Index].Cells[2].Value = cantidadActual + Valor;
                tabla.Rows[tabla.CurrentRow.Index].Cells[2].Value = inspeccionPresentador.ContabilizarDefecto(pie, idDefecto, op.Numero);
                lbParesDePrimera.Text = "" + inspeccionPresentador.ObtenerCantidadPrimera(op.Numero);
                this.notificarObservadores();           
            }

        }
        private void IzqObservado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ActualizarContador(IzqObservado, "Izquierdo");

        }

        private void IzqReproceso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.ActualizarContador(IzqReproceso, "Izquierdo");
           
        }

        private void DerObservado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.ActualizarContador(DerObservado, "Derecho");
            
        }

        private void DerReproceso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.ActualizarContador(DerReproceso, "Derecho");
            
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (lbParesDePrimera.Text.Equals("0")  && Valor < 0)
            {
                //mostraremos un mensaje en un label para no entorpecer
            }
            else
            {
                inspeccionPresentador.RegistrarParPrimera("ParDePrimera", int.Parse(cbxHoras.SelectedItem.ToString()), Valor, op.Numero);
                lbParesDePrimera.Text = "" + inspeccionPresentador.ObtenerCantidadPrimera(op.Numero);
                this.notificarObservadores();
            }

            
        }











        //Hay que borrar pero da error si las saco*
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void DerObservado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = DerObservado.Rows[DerObservado.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla DerObser y mi valor en la celda es: " + a);
        }

        private void IzqReproceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = IzqReproceso.Rows[IzqReproceso.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla IzqReproceso y mi valor en la celda es: " + a);
        }

        private void DerReproceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = DerReproceso.Rows[DerReproceso.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla DerReproceso y mi valor en la celda es: " + a);
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if(hermanado1.Visible == true)
            {
                this.Size = new Size(1280, 721);
                hermanado1.Visible = false;
            }
            else
            {
                hermanado1.Visible = true;
                hermanado1.indicarNumeroOP(op.Numero);
                this.Size = new Size(1280, 900);
            }
            
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void lbObj_Click(object sender, EventArgs e)
        {

        }


        //*


    }
}
