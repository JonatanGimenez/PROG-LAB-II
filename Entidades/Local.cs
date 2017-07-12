using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class Local
    {
        protected int _anchoDeFrente;
        protected string _direccion;

        protected abstract int Legajo
        {
            get;
            set;
        }

        public int AnchoDeFrente
        {
            set
            {
                this._anchoDeFrente = value;
                if (this._anchoDeFrente < 0 || this._anchoDeFrente % 2 == 0)
                {
                    this._anchoDeFrente = 0;
                    throw new Exception("Ancho de frente no valido.");
                }
            }
        }

        public Local(int ancho, string direccion)
        {
            try
            {
                this.Excepcion(ancho);
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }

            this._direccion = direccion;
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine("Direccion: " + this._direccion);
            SB.AppendLine("Ancho del frente: " + this._anchoDeFrente);

            return SB.ToString();
        }

        public void Excepcion(int valor)
        {
            try
            {
                this.AnchoDeFrente = valor;
            }
            catch (Exception excepcion)
            {
                throw excepcion;
            }
        }
    }
}
