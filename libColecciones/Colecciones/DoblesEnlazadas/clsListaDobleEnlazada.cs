using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.DoblesEnlazadas
{
    public class clsListaDobleEnlazada<Tipo>: clsTADDobleEnlazado<Tipo>, iLista<Tipo>
    {
        #region metodos
        #region Constructor
        public clsListaDobleEnlazada()
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
