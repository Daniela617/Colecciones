using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Servicios.Ordenamiento;

namespace uTestColecciones
{
    [TestClass]
    public class uTestOrdenamiento
    {
        [TestMethod]
        public void uTestBurbuja()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.Burbuja(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }
            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void uTestBurbujaMejorado()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.BurbujaMejorado(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }
            }
            Assert.AreEqual(true, varOrdenado);

        }
        [TestMethod]
        public void uTestBurbujaBiDireccional()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.BurbujaBiDireccional(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }
            }
            Assert.AreEqual(true, varOrdenado);

        }
        [TestMethod]
        public void uTestInsercion()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.Insercion(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }
            }
            Assert.AreEqual(true, varOrdenado);

        }
        [TestMethod]
        public void uTestSeleccion()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.Seleccion(ref vecPrueba);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }
            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void uTestQuickSort()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.QuickSort(ref vecPrueba, 0, vecPrueba.Length - 1);
            bool varOrdenado = true;

            for (int i = 0; i < vecPrueba.Length - 1; i++)
            {
                if (vecPrueba[i + 1] < vecPrueba[i])
                {
                    varOrdenado = false;
                    break;
                }
            }
            Assert.AreEqual(true, varOrdenado);
        }
        [TestMethod]
        public void UTestBuscarSecuencial()
        {
            int[] vecPrueba = new int[30000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            Assert.AreEqual(0, clsBrokerOrdenamiento.buscarSecuencial(ref vecPrueba, 30000));
        }

        [TestMethod]
        public void UTestBuscarSecuencialBinaria()
        {
            int[] vecPrueba = new int[50000];
            for (int i = 0; i < vecPrueba.Length; i++)
            {
                vecPrueba[i] = vecPrueba.Length - i;
            }
            clsBrokerOrdenamiento.QuickSort(ref vecPrueba, 0, vecPrueba.Length - 1);
            Assert.AreEqual(49999, clsBrokerOrdenamiento.buscarBinario(ref vecPrueba, 0, vecPrueba.Length, 50000));
            Assert.AreEqual(-1, clsBrokerOrdenamiento.buscarBinario(ref vecPrueba, 0, vecPrueba.Length, 50001));

        }
    }
}
