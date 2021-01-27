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

        public VistaInspeccion(OrdenDeProduccionDto op, UsuarioDto supervisorCalidad, List<DefectoDto> observados, List<DefectoDto> Reproceso, TurnoDto t)//List<int> horasTurno)
        {
            this.op = op;
            this.supervisorCalidad = supervisorCalidad;
            this.observados = observados;
            this.Reproceso = Reproceso;
            this.t = t;
            InitializeComponent();
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
                IzqObservado.Rows.Add(d.IdDefecto,d.Detalle);//El tercer parametro sera la cantidad contada desde un metodo 
            }

            IzqObservado.Columns[0].Width = 40;
            IzqObservado.Columns[1].Width = 100;
            IzqObservado.Columns[2].Width = 60;

            foreach (DefectoDto d in Reproceso)
            {
                IzqReproceso.Rows.Add(d.IdDefecto, d.Detalle);//El tercer parametro sera la cantidad contada desde un metodo 
            }
            IzqReproceso.Columns[0].Width = 40;
            IzqReproceso.Columns[1].Width = 100;
            IzqReproceso.Columns[2].Width = 60;

            foreach (DefectoDto d in observados)
            {
                DerObservado.Rows.Add(d.IdDefecto, d.Detalle);//El tercer parametro sera la cantidad contada desde un metodo 
            }
            DerObservado.Columns[0].Width = 40;
            DerObservado.Columns[1].Width = 100;
            DerObservado.Columns[2].Width = 60;

            foreach (DefectoDto d in Reproceso)
            {
                DerReproceso.Rows.Add(d.IdDefecto, d.Detalle);//El tercer parametro sera la cantidad contada desde un metodo 
            }
            DerReproceso.Columns[0].Width = 40;
            DerReproceso.Columns[1].Width = 100;
            DerReproceso.Columns[2].Width = 60;
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

        

        private void IzqReproceso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string a = IzqReproceso.Rows[IzqReproceso.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla IzqReproceso y mi valor en la celda es: " + a);
        }

        private void DerObservado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string a = DerObservado.Rows[DerObservado.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla DerObser y mi valor en la celda es: " + a);
        }

        private void DerReproceso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string a = DerReproceso.Rows[DerReproceso.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla DerReproceso y mi valor en la celda es: " + a);
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

        private void IzqObservado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = IzqObservado.Rows[IzqObservado.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("Soy la tabla IzqObser y mi valor en la celda es: " + a);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TColores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CON ESTO TOMAMOS EL ID DE LA LINEA DEL DATAGRIDVIEW 
            //string a = TColores.Rows[TColores.CurrentRow.Index].Cells[1].Value.ToString();
            //MessageBox.Show(a);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //*
    }
}
