using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Entidades
{
    [XmlInclude(typeof(TiendaDeCafe))]
    public abstract class Tienda:Local,IArchivos<Tienda>
    {
        private string _direccion;
        private int _anchoDeFrente;

        public int AnchoDeFrente 
        { 
            get 
            {
                return this._anchoDeFrente;
            }
            set
            {
                //if (value < 0 || value % 2 != 0)
                //{
                //    this._anchoDeFrente = -1;
                //}
                this._anchoDeFrente = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this._direccion;
            }

            set
            {
                this._direccion = value;
            }
        }

        protected override int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        /// <summary>
        /// Retorna una cadena con toda la info 
        /// de la clase Tienda.
        /// </summary>
        /// <returns></returns>
        public string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Direccion: " + this._direccion);
            sb.AppendLine("Ancho de Frente: " + this._anchoDeFrente.ToString());
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }

        

        public void guardar()
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Tienda));
                using (XmlTextWriter escritor = new XmlTextWriter("d:\\datos.xml", Encoding.UTF8))
                {
                    serializador.Serialize(escritor,this);
                }
            }
            catch (Exception ex)
            {
                throw new NoGuardarException("" + ex.Message);
            }
        }

        public void leer()
        {
            try
            {
                Tienda tienda = null;

                XmlSerializer deserializador = new XmlSerializer(typeof(Tienda));
                using (XmlTextReader lector = new XmlTextReader("d:\\datos.xml"))
                {
                    tienda =(Tienda)deserializador.Deserialize(lector);
                }
            }
            catch (Exception ex)
            {
                
                throw new NoLeeException("" + ex.Message);
            }
        }


        public Tienda()
        {

        }

        public Tienda(string direccion, int anchoDeFrente)
        {
            this._direccion = direccion;
            this.AnchoDeFrente = anchoDeFrente;
        }

        public Tienda(string direccion, int anchoDeFrente, int legajo):this(direccion,anchoDeFrente)
        {
            this._legajo = legajo;            
        }

        //protected void verificoAnchoFrente()
        //{
        //    if (AnchoDeFrente == -1)
        //    {
        //        throw new Exception("paso metodo de instancia");
        //    }
        //}
        
    }
}
