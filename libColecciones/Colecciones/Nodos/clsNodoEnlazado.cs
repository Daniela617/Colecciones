
using Servicios.Colecciones.Interfaces;
using System;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodoEnlazado<Tipo> : clsNodo<Tipo>, iNodoEnlazado<Tipo>
    {
        #region atributos
        private clsNodoEnlazado<Tipo> atrSiguiente;
        #endregion
        #region metodos
        #region constructores
        public clsNodoEnlazado()
        {
            throw new NotImplementedException();
        }
        public clsNodoEnlazado(Tipo prmItem) : base(prmItem) { }
        #endregion
        #region accesores
        public clsNodoEnlazado<Tipo> darSiguiente()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}