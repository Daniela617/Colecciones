using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using System;

namespace Servicios.Colecciones.Tads
{
    public class clsTADDobleEnlazado<Tipo>:clsTAD<Tipo>,iTADDobleEnlazada<Tipo>
    {
        #region atributos
        private clsNodoDobleEnlazado<Tipo> atrPrimero;
        private clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #region operaciones
        #region constructores
        public clsTADDobleEnlazado()
        {

        }
        #endregion
        #region accesores
        public clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public clsNodoDobleEnlazado<Tipo> darUltimo()
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
