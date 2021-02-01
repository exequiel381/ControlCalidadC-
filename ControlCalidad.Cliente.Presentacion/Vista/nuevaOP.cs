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
    public partial class nuevaOP : Form, IOrdenDeProduccion

    {
        UsuarioDto supervisorLinea;
        UsuarioDto[] supervisoresCalidadDisponibles;
        LineaDto[] LineasDisponibles;
        ModeloDto[] modelos;
        ColorDto[] colores;
        public nuevaOP(UsuarioDto supervisorLineaActual)
        {
            this.supervisorLinea = supervisorLineaActual;
            InitializeComponent();
        }


        public LineaDto Linea {
            get {

                LineaDto l=null;

                foreach(LineaDto t in LineasDisponibles)
                {
                    if(cbxLineasDisponibles.SelectedValue.Equals(t.Numero) )
                    {
                        l = t;
                    }
                }

                return l;
            }

            set {
                cbxLineasDisponibles.Items.Add(value);
            } 
            
         }
        public int NumeroOP { 
            get { return int.Parse(txtNumero.Text); } 
            set { txtNumero.Text = "" + value; } }
        public UsuarioDto SupervisorLineaAsignado { 
           
            get { return supervisorLinea; } 
            set { supervisorLinea = value; } }
        public UsuarioDto SupervisorCalidadAsignado { 
            
            get {
                UsuarioDto l = null;

                foreach (UsuarioDto t in supervisoresCalidadDisponibles)
                {
                    if (cbxSupervisoresDisponibles.SelectedValue.Equals(t.Dni))
                    {
                       
                        l = t;
                    }

                }



                return l;
            } 
            set { cbxSupervisoresDisponibles.SelectedValue = value; } }

        public ModeloDto modelo { 
            
            get {
                ModeloDto l = null;

                foreach (ModeloDto t in modelos)
                {
                    if (cbxModelos.SelectedValue.Equals(t.Sku))
                    {
                        l = t;
                    }
                }

                return l;
            } 
            set { cbxModelos.SelectedItem = value; } }

        public ColorDto color
        {
            get {
                ColorDto l = null;

                foreach (ColorDto t in colores)
                {
                    if (cbxColores.SelectedValue.Equals(t.Codigo))
                    {
                        l = t;
                    }
                }

                return l;
            }
            set { cbxColores.SelectedItem = value; }
        }
    
           
        public void RellenarCampos(UsuarioDto[] supervisoresCalidadDisponibles, LineaDto[] LineasDisponibles, ModeloDto[] modelos, ColorDto[] colores)//List<LineaDto> lineas, UsuarioDto[] supervisoresCalidadDisponibles, List<ModeloDto> modelos, List<ColorDto> colores )
        {

            this.supervisoresCalidadDisponibles = supervisoresCalidadDisponibles;
            this.LineasDisponibles = LineasDisponibles;
            this.modelos = modelos;
            this.colores = colores;

            cbxSupervisoresDisponibles.DataSource = supervisoresCalidadDisponibles;
            cbxSupervisoresDisponibles.ValueMember = "Dni";
            cbxSupervisoresDisponibles.DisplayMember = "usuario";


            cbxColores.DataSource = colores;
            cbxColores.ValueMember = "Codigo";
            cbxColores.DisplayMember = "Descripcion";

            cbxModelos.DataSource = modelos;
            cbxModelos.ValueMember = "SKU";
            cbxModelos.DisplayMember = "Denominacion";

            cbxLineasDisponibles.DataSource = LineasDisponibles;
            cbxLineasDisponibles.ValueMember = "Numero";
            cbxLineasDisponibles.DisplayMember = "Numero";

            
        }

        private void nuevaOP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                OrdenDeProduccionPresentador opp = new OrdenDeProduccionPresentador(this);
                opp.CrearNuevaOP();
                this.Visible = false;
            }
            
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            try
            {
                int.Parse(txtNumero.Text);
                return ok;
                
            }catch(Exception e)
            {
                
                ok = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(txtNumero,"DEBE INGRESAR UN NUMERO ENTERO");
                return ok;
            }
        }

        

        private void setObjetivo(object sender, EventArgs e)
        {
            foreach (ModeloDto t in modelos)
            {
                if (cbxModelos.SelectedValue.Equals(t.Sku))
                {
                    //lbObjetivoModelo.Text =""+ 10;
                    lbObjetivoModelo.Text = "" + t.Objetivo;
                }
            }
        }
    }
}
