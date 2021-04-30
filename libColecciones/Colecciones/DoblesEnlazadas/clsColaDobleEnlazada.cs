using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.DoblesEnlazadas
{
    public class clsColaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo>, iCola<Tipo>
    {
        #region metodos
        #region constructores
        public clsColaDobleEnlazada()
        {

        }
        #endregion
        #region CRUD
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
