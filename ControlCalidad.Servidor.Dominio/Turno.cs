using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Servidor.Dominio
{
    public class Turno 
    {
        
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Descripcion { get; set; }


        public Turno(DateTime inicio, DateTime fin)
        {
            Inicio = inicio;
            Fin = fin;
            
        }
        public Turno()
        {

        }

        public override string ToString()
        {
            return Descripcion;
        }
        public List<int> GetListaDeHoras()
        {
            List<int> listaHoras = new List<int>();
            int total = Math.Abs(Fin.Subtract(Inicio).Hours);
            DateTime inicio = Inicio;
            for (int i = 1; i <= total; i++)
            {
                listaHoras.Add(int.Parse(inicio.ToString("HH")));
                inicio = inicio.AddHours(1);
            }
            return listaHoras;
        }
        public bool SoyTurnoActual()
        {
            var HoraInicio = Inicio.TimeOfDay;
            var HoraFin = Fin.TimeOfDay;
            var hora = DateTime.Now.TimeOfDay;

            
            return HoraInicio <= HoraFin ?
            hora >= HoraInicio && hora < HoraFin :
            hora >= HoraInicio || hora < HoraFin;
        }


        public List<int> GetHorasHabilitadasParaTrabajarPosterioresAlaActual()
        {
            List<int> HorasHabilitadasParaTrabajarPosterioresAlaActual = new List<int>();


            foreach (int h in this.GetListaDeHoras()) 
            {
                if(h >= DateTime.Now.Hour)
                {
                    HorasHabilitadasParaTrabajarPosterioresAlaActual.Add(h);
                }
            }

            return HorasHabilitadasParaTrabajarPosterioresAlaActual;
        }

        public TimeSpan HeFilalizadoHace()
        {
            return DateTime.Now.Subtract(Fin);
        }
    }
}
