using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroLibros.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroLibros.Entidades;
using RegistroLibros.BLL.Tests;

namespace RegistroLibros.BLL.Tests
{
    [TestClass()]
    public class LibrosBllTests
    {
        [TestMethod()]
        public void GuardarTest()

        {
          bool paso;
            Libros libros = new Libros();
            libros.Id = 13;
            libros.Nombre = "Don Quijote";
            libros.Tipo = "Sigla";
            libros.Siglas = "Dqj";
            paso = LibrosBll.Guardar(libros);
            Assert.AreEqual(paso, true);

          
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }
    }
}