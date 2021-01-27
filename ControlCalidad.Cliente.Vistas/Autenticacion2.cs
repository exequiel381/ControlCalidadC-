using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Vistas
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
                return txtUsuario.Text;
            }
            set
            {
                txtUsuario.Text = value;
            }
        }

        public string contrasenia
        {
            get
            {
                return txtContrasenia.Text;
            }
            set
            {
                txtContrasenia.Text = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           //var p = new AutenticacionPresentador(this);
        }
    }
}
