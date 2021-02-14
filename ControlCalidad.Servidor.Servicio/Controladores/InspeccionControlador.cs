﻿using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    public class InspeccionControlador
    {
        public void RegistrarHallazgo(int NumeroOP, Hallazgo hallazgo)
        {
            OrdenDeProduccion Orden=null;

            foreach(OrdenDeProduccion op in Repositorio.GetOrdenes())
            {
                if (op.Numero == NumeroOP)
                {
                    op.RegistrarHallazgo(hallazgo);
                    Orden = op;
                }
            }

            Repositorio.getRepositorio().ActualizarOP(Orden);
           
        }
        public int ContabilizarDefecto(string pie, int idDefecto, int NumeroOP)
        {
            OrdenDeProduccion op = Repositorio.getRepositorio().ObtenerOrden(NumeroOP);
            return op.ContabilizarDefecto(pie, idDefecto);
        }

        public void RegistrarParPrimera(string primera, int hora, int Valor, int NumeroOP)
        {
            OrdenDeProduccion op = Repositorio.getRepositorio().ObtenerOrden(NumeroOP);

            op.RegistrarParPrimera(primera,hora,Valor);

            Repositorio.getRepositorio().ActualizarOP(op);


        }

        public int ObtenerCantidadPrimera(int NumeroOP)
        {
            OrdenDeProduccion op = Repositorio.getRepositorio().ObtenerOrden(NumeroOP);
            return op.ObtenerCantidadPrimera();
        }

        public void GuardarDatosHermanado(int numeroOP, int primera, int segunda)
        {
            //Buscamos la op seteamos las cantidades y guardamos los cambios
        }
    }

    






}
