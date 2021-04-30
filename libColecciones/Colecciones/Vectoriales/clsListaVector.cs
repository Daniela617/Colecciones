using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo>
    {
        #region operaciones
        #region Constructores
        public clsListaVector()
        {

        }
        public clsListaVector(int prmCapacidad):base(prmCapacidad)
        {

        }
        #endregion
        #region CRUD
        public bool Agregar(Tipo prmItem)
        {
            return false;
        }
        public bool Insertar(int prmIndice, Tipo prmItem)
        {
            return false;
        }
        public bool Remover(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        public bool Modificar(int prmIndice, Tipo prmItem)
        {
            return false;
        }
        public bool Recuperar(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        public bool Encontrar(Tipo prmItem, ref int prmIndice)
        {
            return false;
        }
        #endregion
        #endregion
    }
}
