using Servicios.Colecciones.Interfaces;
using System;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodo<Tipo>:iNodo<Tipo>
    {
        #region atributos
        private Tipo atrItem = default(Tipo);
        #endregion
        #region metodos
        #region constructores
        public clsNodo() { }
        public clsNodo(Tipo prmItem)
        {

        }
        #endregion
        public Tipo darItem()
        {
            return default(Tipo);
        }
        public void ponerItem(Tipo prmContenido) { }
        #endregion
    }
}
