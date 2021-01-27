using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Servidor.Dominio.Tests
{
    [TestClass()]
    public class TurnoTests
    {
        [TestMethod()]
        public void PrubaTurnoTardeTest()
        {
            DateTime inicio1 = new DateTime(2020, 05, 05, 8, 00, 00);
            DateTime inicio2 = new DateTime(2020, 05, 05, 16, 00, 00);
            DateTime fin1 = new DateTime(2020, 05, 05, 12, 00, 00);
            DateTime fin2 = new DateTime(2020, 05, 05, 20, 00, 00);

            Turno mañana = new Turno(inicio1, fin1);
            mañana.Descripcion = "Mañana";
            Turno tarde = new Turno(inicio2, fin2);
            tarde.Descripcion = "Tarde";

            Assert.IsTrue(tarde.SoyTurnoActual());
        }

        [TestMethod()]
        public void PruebaObtenerListaDeHorasDeUnTurno()
        {
            DateTime inicio1 = new DateTime(2020, 05, 05, 8, 00, 00);
            DateTime fin1 = new DateTime(2020, 05, 05, 12, 00, 00);
           

            Turno mañana = new Turno(inicio1, fin1);
            mañana.Descripcion = "Mañana";

            bool b = false;
            int i = 8;

            List<int> AComparar = new List<int>();
            AComparar.Add(8);
            AComparar.Add(9);
            AComparar.Add(10);
            AComparar.Add(11);


            foreach(int a in mañana.GetListaDeHoras())
            {
                if (a == i) { b = true; i++; }

                else b = false;


            }

            Assert.IsTrue(b);

        }
    }
}