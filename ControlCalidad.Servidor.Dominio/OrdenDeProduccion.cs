using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class OrdenDeProduccion
    {
        public int Numero { get; set; }
        public string Estado { get; set;}

        public Linea lineaAsignada { get; set;}
    
        public Usuario SupLineaAsignado { get; set;}

        public Usuario SupCalidadAsignado { get; set;}

        public Color Color { get; set; }
        public Modelo modelo { get; set; }

        public List<Hallazgo> hallazgos = new List<Hallazgo>();
        
        public List<Hallazgo> ParesDePrimera = new List<Hallazgo>();
        

       public void RegistrarHallazgo(Hallazgo h)
        {
            this.hallazgos.Add(h);
        }

       public int ContabilizarDefecto(string pie, int idDefecto)
        {
            int cantidad=0;

            //cantidad = hallazgos.FindAll(h => h.pie==pie && h.defecto.idDefecto==idDefecto).Count;

            foreach(Hallazgo h in hallazgos.FindAll(h => h.pie == pie && h.defecto.idDefecto == idDefecto))
            {
                cantidad = cantidad+h.Valor;
            }

            return cantidad;
        }

        public void RegistrarParPrimera(string primera, int hora, int Valor)
        {

            Hallazgo h = new Hallazgo
            {
                ParDePrimera = primera,
                hora = hora,
                Valor = Valor
            };
            ParesDePrimera.Add(h);
        }

        public int ObtenerCantidadPrimera()
        {
            int cantidad = 0;

            //cantidad = hallazgos.FindAll(h => h.pie==pie && h.defecto.idDefecto==idDefecto).Count;

            foreach (Hallazgo h in ParesDePrimera)
            {
                cantidad = cantidad + h.Valor;
            }

            return cantidad;
        }

    }
}
