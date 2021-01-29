using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlCalidad.Servidor.Servicio.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Datos;

namespace ControlCalidad.Servidor.Servicio.Controladores.Tests
{
    [TestClass()]
    public class InspeccionControladorTests
    {
        [TestMethod()]
        public void RegistrarHallazgoTest()
        {
            Defecto defPrueba = new Defecto
            {
                Detalle = "Despegado",
                idDefecto = 25,
                tipoDefecto = "Reproceso"
            };

            Hallazgo hPrueba = new Hallazgo
            { //Op 300 no tiene defectos
                pie = "Izquierdo",
                hora = 10,
                defecto = defPrueba
            };

            InspeccionControlador ic = new InspeccionControlador();
            ic.RegistrarHallazgo(300,hPrueba);

           Hallazgo encontrado = Repositorio.getRepositorio().ordenes.Find(op => op.Numero == 300).hallazgos.Find(h => h.defecto==defPrueba && h.hora==10 && h.pie=="Izquierdo");

           Assert.AreEqual(hPrueba,encontrado);
        }
    }
}