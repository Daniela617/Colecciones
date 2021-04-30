using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADEnlazada<Tipo>
    {
        #region accesores
        clsNodoEnlazado<Tipo> darPrimero();
        clsNodoEnlazado<Tipo> darUltimo();
        #endregion
    }
}
