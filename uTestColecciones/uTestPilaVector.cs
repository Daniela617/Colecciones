using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Servicios.Colecciones.Enlazadas;
using Servicios.Colecciones.DoblesEnlazadas;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
{
    [TestClass]
    public class uTestPilaVector
    {
        private clsPilaVector<int> miPila;
        [TestMethod]
        public void uTestConstructorNoParametrizado()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(100, miPila.darCapacidad());
            Assert.AreEqual(100, miPila.darItems().Length);
            Assert.AreEqual(0, miPila.darLongitud());
            #endregion
        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(100, miPila.darCapacidad());
            Assert.AreEqual(100, miPila.darItems().Length);
            Assert.AreEqual(0, miPila.darLongitud());
            #endregion
        }
        [TestMethod]
        public void uTestApilarVectoriales()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.Apilar(100));
            Assert.AreEqual(1, miPila.darLongitud());
            Assert.AreEqual(100, miPila.darItems()[0]);

            #endregion
        }
        [TestMethod]
        public void uTestApilarEnlazadas()
        {
            #region Configurar
            clsPilaEnlazada<int> miPila = new clsPilaEnlazada<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.Apilar(123));
            Assert.AreEqual(1, miPila.darLongitud());

            #endregion
        }
        [TestMethod]
        public void uTestApilarDoblesEnlazadas()
        {
            #region Configurar
            clsPilaDobleEnlazada<int> miPila = new clsPilaDobleEnlazada<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.Apilar(123));
            Assert.AreEqual(1, miPila.darLongitud());

            #endregion
        }

    }
}
