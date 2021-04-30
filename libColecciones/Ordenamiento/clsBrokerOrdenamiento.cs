

namespace Servicios.Ordenamiento
{
    public static class clsBrokerOrdenamiento
    {
        #region Referencias
        //https://guias.makeitreal.camp/algoritmos/complejidad, https://www.youtube.com/watch?v=EV59OZiVbOc
        // http://exa.unne.edu.ar/informatica/programacion1/public_html/archivos/Tema10ComplejidadAlgoritmica.pdf
        #endregion
        /// <summary>
        /// O(n) “O-Grande”: “Nunca será peor que… o al menos será igual de malo...”.
        /// o(n) “o- pequeña” o límite no ajustado: “Nunca será peor…”
        /// Ω(n) “Omega-grande”: “Nunca será mejor que… o al menos es tan bueno como....”
        /// -------------------------------------------------------------------------------------
        /// Se implementan como referencia para comparar su desempeño contra los servicios de ordenamiento
        /// de la Libreria´por la clase TAD Y TAD vectorial...
        /// </summary>
        #region metodos

        #region ordenamiento
        /// <summary>
        /// O(n) = n^2
        /// o(n) = n^3
        /// Omega(n)= n or n^2
        /// </summary>
        /// <param name="prmVector"></param>
        public static void Burbuja(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varElementoTemporal;

            for (varPosExterior = 1; varPosExterior < prmVector.Length; varPosExterior++)
            {
                for (varPosInterior = 0; varPosInterior < prmVector.Length - varPosExterior; varPosInterior++)
                {
                    if (prmVector[varPosInterior] > prmVector[varPosInterior + 1])
                    {
                        varElementoTemporal = prmVector[varPosInterior];
                        prmVector[varPosInterior] = prmVector[varPosInterior + 1];
                        prmVector[varPosInterior + 1] = varElementoTemporal;
                    }
                }
            }
        }

        /// <summary>
        /// O(n) = n^2
        /// o(n) = n^3
        /// Omega(n)= n or n^2
        /// </summary>
        public static void BurbujaMejorado(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varElementoTemporal;
            bool varHuboIntercambio;
            varPosExterior = 1;
            varHuboIntercambio = true;

            while ((varPosExterior < prmVector.Length) && (varHuboIntercambio == true))
            {
                varPosExterior = varPosExterior + 1;
                varHuboIntercambio = false;
                for (varPosInterior = 0; varPosInterior <= prmVector.Length - varPosExterior; varPosInterior++)
                {
                    if (prmVector[varPosInterior] > prmVector[varPosInterior + 1])
                    {
                        varElementoTemporal = prmVector[varPosInterior];
                        prmVector[varPosInterior] = prmVector[varPosInterior + 1];
                        prmVector[varPosInterior + 1] = varElementoTemporal;
                        varHuboIntercambio = true;
                    }

                }
            }
        }

        /// <summary>
        /// O(n)=n^2
        /// o(n) = n^3
        /// Omega(n)= n or n^2
        /// </summary>
        public static void BurbujaBiDireccional(ref int[] prmVector)
        {
            bool varHuboIntercambios;
            int varPos, varElementoTemporal;
            do
            {
                varHuboIntercambios = false;
                for (varPos = 0; varPos < prmVector.Length - 1; varPos++)
                {
                    if (prmVector[varPos] > prmVector[varPos + 1])
                    {
                        varElementoTemporal = prmVector[varPos];
                        prmVector[varPos] = prmVector[varPos + 1];
                        prmVector[varPos + 1] = varElementoTemporal;
                        varHuboIntercambios = true;
                    }
                }
                if (varHuboIntercambios == false)
                {
                    break;
                }
                varHuboIntercambios = false;
                for (varPos = prmVector.Length - 2; varPos >= 0; varPos--)
                {
                    if (prmVector[varPos] > prmVector[varPos + 1])
                    {
                        varElementoTemporal = prmVector[varPos];
                        prmVector[varPos] = prmVector[varPos + 1];
                        prmVector[varPos + 1] = varElementoTemporal;
                        varHuboIntercambios = true;
                    }
                }
            } while (varHuboIntercambios == true);
        }

        /// <summary>
        /// O(n)= n^2
        /// o(n) = n^3
        /// Omega(n)= n or n^2
        /// </summary>
        public static void Insercion(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varElementoInsertado;
            for (varPosExterior = 1; varPosExterior < prmVector.Length; varPosExterior++)
            {
                varElementoInsertado = prmVector[varPosExterior];
                varPosInterior = varPosExterior - 1;
                while ((varPosInterior >= 0) && (prmVector[varPosInterior] != varElementoInsertado) && (prmVector[varPosInterior] > varElementoInsertado))
                {
                    prmVector[varPosInterior + 1] = prmVector[varPosInterior];
                    varPosInterior = varPosInterior - 1;
                }
                prmVector[varPosInterior + 1] = varElementoInsertado;
            }
        }

        /// <summary>
        /// O(n)= n^2
        /// o(n) = n^3
        /// Omega(n)= n or n^2
        /// </summary>
        public static void Seleccion(ref int[] prmVector)
        {
            int varPosExterior, varPosInterior, varPosDelMinimo, varElementoTemporal;
            for (varPosExterior = 0; varPosExterior <= prmVector.Length - 1; varPosExterior++)
            {
                varPosDelMinimo = varPosExterior;
                for (varPosInterior = varPosExterior + 1; varPosInterior < prmVector.Length; varPosInterior++)
                {
                    if (prmVector[varPosInterior] < prmVector[varPosDelMinimo])
                    {
                        varPosDelMinimo = varPosInterior;
                    }
                }
                if (varPosDelMinimo != varPosExterior)
                {
                    varElementoTemporal = prmVector[varPosDelMinimo];
                    prmVector[varPosDelMinimo] = prmVector[varPosExterior];
                    prmVector[varPosExterior] = varElementoTemporal;
                }
            }
        }

        /// <summary>
        /// O(n)= n^2
        /// o(n) = n^3
        /// Omega(n)= n or n^2 or n*log(n)
        /// </summary>
        public static void QuickSort(ref int[] prmVector, int prmPosDelPrimero, int prmPosDelUltimo)
        {
            int varPosIzquierdo, varPosDerecho, varElementoPivote, varElementoTemporal;
            varElementoPivote = prmVector[(prmPosDelPrimero + prmPosDelUltimo) / 2];
            varPosIzquierdo = prmPosDelPrimero;
            varPosDerecho = prmPosDelUltimo;
            while (varPosIzquierdo <= varPosDerecho && (prmPosDelUltimo - prmPosDelPrimero) > 0)
            {
                while (prmVector[varPosIzquierdo] < varElementoPivote)
                {
                    varPosIzquierdo = varPosIzquierdo + 1;
                }
                while (prmVector[varPosDerecho] > varElementoPivote)
                {
                    varPosDerecho = varPosDerecho - 1;
                }
                if (varPosIzquierdo <= varPosDerecho)
                {
                    varElementoTemporal = prmVector[varPosIzquierdo];
                    prmVector[varPosIzquierdo] = prmVector[varPosDerecho];
                    prmVector[varPosDerecho] = varElementoTemporal;
                    varPosIzquierdo = varPosIzquierdo + 1;
                    varPosDerecho = varPosDerecho - 1;
                }
            }
            if (prmPosDelPrimero < varPosDerecho)
            {
                QuickSort(ref prmVector, prmPosDelPrimero, varPosDerecho);
            }
            if (varPosIzquierdo < prmPosDelUltimo)
            {
                QuickSort(ref prmVector, varPosIzquierdo, prmPosDelUltimo);
            }
        }
        #endregion
        #region búsqueda
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prmVector"></param>
        /// <param name="prmItem"></param>
        /// <returns></returns>

        public static int  buscarSecuencial( ref int[] prmVector, int prmItem)
        {
            int  varEncontrar = -1;
            for (int varPosicion=0; varPosicion< prmVector.Length; varPosicion++)
            {
                if (prmVector[varPosicion] == prmItem)
                {
                    varEncontrar = varPosicion;
                }
            }
            return varEncontrar;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prmVector"></param>
        /// <param name="prmTopeInferior"></param>
        /// <param name="prmTopeSuperior"></param>
        /// <param name="prmItem"></param>
        /// <returns></returns>
        public static int buscarBinario(ref int[] prmVector, int prmTopeInferior, int prmTopeSuperior, int prmItem)
        {
            int varPosicionCentro;
            if (prmTopeInferior >= prmTopeSuperior)
                return -1;
            else
            {
                varPosicionCentro = (prmTopeSuperior + prmTopeInferior) / 2;
                if (prmVector[varPosicionCentro] < prmItem)
                    return buscarBinario(ref prmVector, varPosicionCentro + 1, prmTopeSuperior, prmItem);
                else
                {
                    if (prmVector[varPosicionCentro] > prmItem)
                        return buscarBinario(ref prmVector, prmTopeInferior, varPosicionCentro - 1, prmItem);
                    else
                    {
                        return varPosicionCentro;
                    }
                }
            }
        }
        #endregion
        #endregion
    }
}
