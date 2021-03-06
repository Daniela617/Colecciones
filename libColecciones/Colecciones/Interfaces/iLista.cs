

namespace Servicios.Colecciones.Interfaces
{
    interface iLista<Tipo>
    {
        #region CRUD
        bool Agregar(Tipo prmItem);

        bool Insertar(int prmIndice, Tipo prmItem);

        bool Remover(int prmIndice, ref Tipo prmItem);

        bool Modificar(int prmIndice, Tipo prmItem);

        bool Recuperar(int prmIndice, ref Tipo prmItem);

        bool Encontrar(Tipo prmItem, ref int prmIndice);
        #endregion
    }
}
