using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace UI_Test
{
    public partial class Form1 : Form
    {
        private const string RUTA = "Archivo.bin";
        private Tienda _tienda;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ancho = 0;
            int legajo = 0;

            try
            {
                if (!(int.TryParse(this.txtAncho.Text, out ancho) | int.TryParse(this.txtLegajo.Text, out legajo)))
                {
                    throw new Exception("Ingreso mal un numero...");
                }

                this._tienda = new Tienda(ancho, this.txtDirreccion.Text, legajo);

                Thread hilo = new Thread(this.Guardar);
                hilo.Start();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                this._tienda.Cargar(out this._tienda, RUTA);
                this.rtxLista.Text = this._tienda.ExponerDatos();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void Guardar()
        {
            try
            {
                this._tienda.Guardar(RUTA);
                MessageBox.Show("Se ha guardado con exito");
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
