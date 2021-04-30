using Servicios.Colecciones.Nodos;


namespace Servicios.Colecciones.Interfaces
{
    public interface iNodoEnlazado<Tipo>
    {
        clsNodoEnlazado<Tipo> darSiguiente();
    }
}
