

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADVectorial<Tipo>
    {
        #region accesores
        Tipo[] darItems();
        int darCapacidad();
        #endregion
        #region mutador
        void ponerItems(Tipo[] prmVector);
        #endregion
    }
}
