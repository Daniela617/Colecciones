using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsColaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iCola<Tipo>
    {
        #region metodos
        #region constructor
        public clsColaEnlazada()
        {

        }
        #endregion
        #region CRUDS
        public bool Encolar(Tipo prmItem)
        {
            return false;
        }
        public bool Desencolar(ref Tipo prmItem)
        {
            return false;
        }
        public bool Revisar(ref Tipo prmItem)
        {
            return false;
        }

        #endregion
        #endregion
    }
}
