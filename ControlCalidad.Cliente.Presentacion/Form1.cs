using ControlCalidad.Cliente.AccesoExterno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var lineas = Adaptador.GetLineas();
            foreach(var l in lineas)
            {
                listBox1.Items.Add($"{l.Numero} - {l.Descripcion}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
