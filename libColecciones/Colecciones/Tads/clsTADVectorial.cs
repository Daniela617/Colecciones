using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo> : clsTAD<Tipo>, iTADVectorial<Tipo>
    {
        #region atributos
        #region propios
        private int atrCapacidad ;
        private Tipo[] atrItems;
        #endregion
        #endregion
        #region operaciones
        #region constructores
        public clsTADVectorial()
        {
            atrCapacidad = 100;
            atrItems = new Tipo[100];
        }
        public clsTADVectorial(int prmCapacidad)
        {

        }
        #endregion
        #region accesores
        public Tipo[] darItems()
        {
            return atrItems;
        }

        public int darCapacidad()
        {
            return atrCapacidad;
        }
        #endregion
        #region mutador
        public void ponerItems(Tipo[] prmVector)
        {

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
        protected override bool InsertarEnMedio(int prmIndice,Tipo prmItem)
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
