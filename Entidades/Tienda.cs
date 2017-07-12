using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public class Tienda:Local,IArchivos<Tienda>
    {
        private int _legajo;

        protected override int Legajo
        {
            get
            {
                { return this._legajo; }
            }
            set
            {
                { this._legajo = value; }
            }
        }

        public Tienda(int ancho, string direccion, int legajo): base(ancho, direccion)
        {
            this._legajo = legajo;
        }

        public string ExponerDatos()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine(base.ToString());
            SB.AppendLine("Legajo: " + this._legajo);

            return SB.ToString();
        }

        public bool Guardar(string ruta)
        {
            IFormatter serializador = new BinaryFormatter();

            try
            {
                using (Stream escritor = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    serializador.Serialize(escritor, this);
                }
            }
            catch (Exception)
            {
                throw new NoGuardaException();
            }

            return true;
        }

        public bool Cargar(out Tienda objeto, string ruta)
        {
            IFormatter desserializador = new BinaryFormatter();

            try
            {
                using (Stream escritor = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    objeto = (Tienda)desserializador.Deserialize(escritor);
                }
            }
            catch (Exception excepcion)
            {
                throw new NoLeeException(excepcion);
            }

            return true;
        }
    }
}
