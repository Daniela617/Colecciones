using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.DoblesEnlazadas
{
    public class clsPilaDobleEnlazada<Tipo>: clsTADDobleEnlazado<Tipo>, iPila<Tipo>
    {
        #region metodos
        #region constructores
        public clsPilaDobleEnlazada()
        {

        }
        
        #endregion
        #region CRUD
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
