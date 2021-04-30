using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD<Tipo> : iTAD<Tipo>
    {
        #region atributos
        #region propios
        private int atrLongitud ;
        #endregion
        #endregion
        #region operaciones
        #region constructor
        public clsTAD()
        {

        }
        #endregion
        #region accesores
        public int darLongitud()
        {
            return atrLongitud;
        }
        #endregion
        #region CRUD
        #region Consultores
        public bool EsValido(int prmIndice)
        {
            return (prmIndice>=0 && prmIndice<atrLongitud);
        }
        #endregion
        #region Insertadores
        protected virtual bool InsertarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected virtual bool InsertarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool InsertarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected bool InsertarEn(int prmIndice , Tipo prmItem)
        {
            if (prmIndice == 0) return InsertarPrimero(prmItem);
            if (prmIndice == atrLongitud) return InsertarUltimo(prmItem);
            if (EsValido(prmIndice)) return InsertarEnMedio(prmIndice,prmItem);
            return false;

        }
        #endregion
        #region Extractores
        protected virtual bool ExtraerPrimero(ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool ExtraerUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool ExtraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return ExtraerPrimero(ref prmItem);

            if (prmIndice == atrLongitud) return ExtraerUltimo(ref prmItem);

            if (EsValido(prmIndice)) return ExtraerEnMedio(prmIndice, ref prmItem);

            return false;
        }
        #endregion
        #region Modificadores
        protected virtual bool ModificarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool ModificarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool ModificarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected bool ModificarEn(int prmIndice, Tipo prmItem)
        {
            if (prmIndice == 0) return ModificarPrimero(prmItem);

            if (prmIndice == atrLongitud) return ModificarUltimo(prmItem);

            if (EsValido(prmIndice)) return ModificarEnMedio(prmIndice, prmItem);

            return false;
        }
        #endregion
        #region Recuperadores
        protected virtual bool RecuperarPrimero(ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool RecuperarUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected virtual bool RecuperarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();

        }
        protected bool RecuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return RecuperarPrimero(ref prmItem);

            if (prmIndice == atrLongitud) return RecuperarUltimo(ref prmItem);

            if (EsValido(prmIndice)) return RecuperarEnMedio(prmIndice, ref prmItem);

            return false;
        }
        #endregion
        #endregion
        #endregion
    }
}
