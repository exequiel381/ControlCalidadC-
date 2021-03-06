﻿using ControlCalidad.Cliente.Presentacion.Presentador;
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
    public partial class VistaSupCalidad : Form
    {
        OrdenDeProduccionDto op;
        UsuarioDto supervisorCalidadActual;

        public VistaSupCalidad(UsuarioDto supervisorCalidadActual)
        {
            this.supervisorCalidadActual = supervisorCalidadActual;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VistaSupCalidad_Load(object sender, EventArgs e)
        {

        }

        public void rellenarCampos(OrdenDeProduccionDto op)//int nOP, string estado, int linea)
        {
            this.op = op;
            lbNOP.Text = "" + op.Numero;
            lbEstado.Text = op.Estado;
            lbLineaOP.Text = "" + op.lineaAsignada.Numero;
        }

        private void btnInspeccionar_Click(object sender, EventArgs e)
        {
            OrdenDeProduccionPresentador opp = new OrdenDeProduccionPresentador(null);
            opp.ComenzarInspeccion(op,supervisorCalidadActual);

        }
    }
}
