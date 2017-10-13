using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionDocenteTest
    {

        [TestMethod]
        public void AgregarDocenteTest()
        {
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionDocente modulo = new ModuloGestionDocente(repositorio);
            modulo.Alta(docente);
            Assert.IsTrue(repositorio.Docentes.Count == 1);
        }
    }
}
