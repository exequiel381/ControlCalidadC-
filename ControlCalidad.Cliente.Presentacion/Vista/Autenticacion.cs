using ControlCalidad.Cliente.Presentador;
using ControlCalidad.Cliente.Vistas;

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
    public partial class Autenticacion : Form, IAutenticacion
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        public string usuario
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;

            }


        }


        public string contrasenia
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var p = new AutenticacionPresentador(this);
            
            bool cerrarVentana = p.Autenticar();
            if (cerrarVentana) this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {

        }
    }
}
