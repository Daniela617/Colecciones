using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iNodo<Tipo>
    {
        #region operaciones
        #region accesores
        Tipo darItem();
        #endregion
        #region mutador
        void ponerItem(Tipo prmContenido);
        #endregion
        #endregion
    }
}

