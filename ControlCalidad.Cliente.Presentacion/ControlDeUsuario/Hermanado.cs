using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCalidad.Cliente.Presentacion.Presentador;

namespace ControlCalidad.Cliente.Presentacion.ControlDeUsuario
{
    public partial class Hermanado : UserControl
    {
        public int NumeroOP {get;set;}

        public Hermanado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hermanado_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InspeccionPresentador ci = new InspeccionPresentador(null);
            ci.GuardarDatosHermanado(NumeroOP,int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            this.lbConfirmacion.Text = "Cambios Guardados";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbConfirmacion.Text = "";
        }

        private void primeraMenos_Click(object sender, EventArgs e)
        {
            this.lbConfirmacion.Text = "";
        }

        private void segundaMenos_Click(object sender, EventArgs e)
        {
            this.lbConfirmacion.Text = "";
        }

        private void segundaMas_Click(object sender, EventArgs e)
        {
            this.lbConfirmacion.Text = "";
        }

        internal void indicarNumeroOP(int numero)
        {
            this.NumeroOP = numero;
        }
    }
}
