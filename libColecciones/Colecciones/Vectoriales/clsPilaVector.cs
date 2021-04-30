using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
namespace Servicios.Colecciones.Vectoriales
{
    public class clsPilaVector<Tipo> : clsTADVectorial<Tipo>, iPila<Tipo>
    {
        #region operaciones
        #region constructores
        public clsPilaVector()
        {
            
        }
        public clsPilaVector(int prmCapacidad):base (prmCapacidad)
        {

        }
        #endregion
        #region CRUD
        public bool Apilar(Tipo prmItem)
        {
            return InsertarEn(0,prmItem);
        }
        public bool Desapilar(ref Tipo prmItem)
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
