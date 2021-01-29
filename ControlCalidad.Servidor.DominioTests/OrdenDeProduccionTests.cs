using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Datos;

namespace ControlCalidad.Servidor.Dominio.Tests
{
    [TestClass()]
    public class OrdenDeProduccionTests
    {
        [TestMethod()]
        public void ContabilizarDefectoTest()
        {
            OrdenDeProduccion op = Repositorio.getRepositorio().ObtenerOrden(300);
            Defecto d = Repositorio.getRepositorio().GetDefectos().First();
            op.RegistrarHallazgo(new Hallazgo { pie = "Izquierdo", defecto = d, hora = 11, Valor = 1 });
            op.RegistrarHallazgo(new Hallazgo { pie = "Izquierdo", defecto = d, hora = 11, Valor = 1 });
            op.RegistrarHallazgo(new Hallazgo { pie = "Izquierdo", defecto = d, hora = 11, Valor = 1 });
            op.RegistrarHallazgo(new Hallazgo { pie = "Izquierdo", defecto = d, hora = 11, Valor = -1 });

            Assert.AreEqual(2,op.ContabilizarDefecto("Izquierdo", d.idDefecto));
        }
    }
}