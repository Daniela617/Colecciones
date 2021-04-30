using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using System;
namespace Servicios.Colecciones.Tads
{
    public class clsTADEnlazado<Tipo>: clsTAD<Tipo>, iTADEnlazada<Tipo>
    {
        #region atributos
        private clsNodoEnlazado<Tipo> atrPrimero;
        private clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        #region operaciones
        #region constructores
        public clsTADEnlazado()
        {
           
        }
        #endregion
        #region accesores
        public clsNodoEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public clsNodoEnlazado<Tipo> darUltimo()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUD
        #region Insertadores
        protected override bool InsertarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool InsertarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool InsertarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Extractores
        protected override bool ExtraerPrimero(ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected override bool ExtraerUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected override bool ExtraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }

        #endregion
        #region Modificadores
        protected override bool ModificarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected override bool ModificarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected override bool ModificarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();

        }

        #endregion
        #endregion
        #endregion
    }
}
