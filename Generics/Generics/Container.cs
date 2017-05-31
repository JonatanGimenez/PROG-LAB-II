using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Container <T> : IEnumerable<T>
    {
        private List<T> _elementos;
        private int _cantidadMaxima;

        public Container(int cantidadMaxima)
        {
            this._elementos = new List<T>();

            this._cantidadMaxima = cantidadMaxima;
        }

        private bool estaLleno()
        {
            return this._elementos.Count == this._cantidadMaxima;
        }

        private bool estaElElemento(T elemento)
        {
            foreach (T item in this._elementos)
            {
                if(item.Equals(elemento))
                return true;
            }

            return false;
        }

        public bool agregar(T elemento)
        {
            this._elementos.Add(elemento);

            return true;
        }

        public static bool operator +(Container <T> deposito, T elemento)
        {
            if (!deposito.estaElElemento(elemento) && !deposito.estaLleno())
            {
                return deposito.agregar(elemento);
            }

            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
