using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : clsTADVectorial<Tipo>, iCola<Tipo>
    {
        #region atributos 

        #endregion
        #region operaciones
        #region constructores
        public clsColaVector()
        {

        }
        public clsColaVector(int prmCapacidad): base (prmCapacidad)
        {

        }
        #endregion
        #region CRUD
        public bool Encolar(Tipo prmItem)
        {
            return false;
        }
        public bool Desencolar( ref Tipo prmItem)
        {
            return false;
        }
        public bool Revisar( ref Tipo prmItem)
        {
            return false;
        }
        #endregion
        #endregion
    }
}
