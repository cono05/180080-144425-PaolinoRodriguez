using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using Logica;
using Dominio;
namespace Pruebas
{
    [TestClass]
    public class ModuloGestionCamionetasTest
    {
        [TestMethod]
        public void AgregarCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20);
            moduloCamionetas.Alta(camioneta);
        }
    }
}
