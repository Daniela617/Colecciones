using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iNodoDobleEnlazado<Tipo>
    {
        clsNodoDobleEnlazado<Tipo> darAnterior();
        clsNodoDobleEnlazado<Tipo> darSiguiente();

    }
}
