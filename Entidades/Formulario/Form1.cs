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
using Excepciones;
using System.Threading;


namespace Formulario
{
    public partial class FrmTienda : Form
    {
        TiendaDeCafe tiendita;

        public FrmTienda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = int.Parse(this.txtLegajo.Text);
                int anchoFrente = int.Parse(this.txtAnchoDeFrente.Text);

                tiendita = new TiendaDeCafe(this.txtDireccion.Text, anchoFrente, legajo);

                //UTILIZO PUNTO Nº10 METODO DE EXTENCION.
                MiClaseMetodoExtencion.SetAnchoDeFrente(tiendita, 2222);

                //UTILIZO THREAD.
                Thread hilo = new Thread(this.tiendita.guardar);

                hilo.Start();
                hilo.Abort();
            }
            catch (NoGuardarException ex)
            {

                MessageBox.Show("" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                Thread hiloLeer = new Thread(this.tiendita.leer);
                hiloLeer.Start();

                //MUESTRO POR PANTALLA LOS DATOS.
                MessageBox.Show(tiendita.ExponerDatos());
                hiloLeer.Abort();
            }
            catch (NoLeeException ex)
            {
                
                MessageBox.Show("" + ex.Message);
            }
           
        }

        
    }
}
