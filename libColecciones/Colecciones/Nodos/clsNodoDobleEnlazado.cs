using Servicios.Colecciones.Interfaces;
using System;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo>: clsNodo<Tipo>, iNodoDobleEnlazado<Tipo>
    {
        #region atributos
        #region asociativos
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        #endregion
        #endregion

        #region metodos
        #region constructores
        public clsNodoDobleEnlazado() { }
        public clsNodoDobleEnlazado(Tipo prmItem): base (prmItem)
        {

        }
        #endregion
        #region accesores
        public clsNodoDobleEnlazado<Tipo> darAnterior()
        {
            throw new NotImplementedException();
        }
        public clsNodoDobleEnlazado<Tipo> darSiguiente()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
