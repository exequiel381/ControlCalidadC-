using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Presentador
{
    public class InspeccionPresentador
    {
        OrdenDeProduccionDto op;

        public InspeccionPresentador(OrdenDeProduccionDto op)
        {
            this.op = op;
        }

        public void RegistrarHallazgo(string pie, int hora, int idDefecto,int Valor)
        {
            //podria hacer que esta funcion me devuelva un entero, contabilizando el defecto que acabo de agregar
            //o ir sumando solo en la vista --
            //de momento los traeremos de Repositorio contabilizados

            HallazgoDto hallazgo = new HallazgoDto();
            hallazgo.defecto = Adaptador.GetDefectos().First(d => d.IdDefecto == idDefecto);
            hallazgo.hora = hora;
            hallazgo.pie = pie;
            hallazgo.Valor = Valor;

            Adaptador.RegistrarHallazgo(op.Numero,hallazgo);


        }

        public int ContabilizarDefecto(string pie, int idDefecto, int NumeroOP)
        {
            return Adaptador.ContabilizarDefecto(pie,idDefecto,NumeroOP);
        }

        public void RegistrarParPrimera(int Valor, int NumeroOP)
        {
            Adaptador.RegistrarParPrimera(Valor,NumeroOP);
        }

        public int ObtenerCantidadPrimera(int NumeroOP)
        {
            return Adaptador.ObtenerCantidadPrimera(NumeroOP);
        }
    }
}
