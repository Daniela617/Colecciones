using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaEnlazada<Tipo>: clsTADEnlazado<Tipo>, iLista<Tipo>
    {
        #region metodos
        #region constructor
        public clsListaEnlazada()
        {

        }
        #endregion
        #region CRUDS
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
