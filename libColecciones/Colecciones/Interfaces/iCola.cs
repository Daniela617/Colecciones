

namespace Servicios.Colecciones.Interfaces
{
    public interface iCola<Tipo>
    {
        #region CRUD
        bool Encolar(Tipo prmItem);
        bool Desencolar(ref Tipo prmItem);
        bool Revisar( ref Tipo prmItem);
        #endregion
    }
}
