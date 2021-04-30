using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaEnlazada<Tipo>: clsTADEnlazado<Tipo>, iPila<Tipo>
    {
        #region metodos
        #region constructor
        public clsPilaEnlazada()
        {
            
        }
        #endregion
        #region CRUDS
        public bool Apilar(Tipo prmItem)
        {
            return InsertarPrimero(prmItem);
        }
        public bool Desapilar(ref Tipo prmItem)
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
