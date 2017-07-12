namespace UI_Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDirreccion = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.rtxLista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtDirreccion
            // 
            this.txtDirreccion.Location = new System.Drawing.Point(97, 12);
            this.txtDirreccion.Name = "txtDirreccion";
            this.txtDirreccion.Size = new System.Drawing.Size(100, 20);
            this.txtDirreccion.TabIndex = 0;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(97, 55);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 1;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(97, 84);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 2;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(5, 19);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(5, 58);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(86, 13);
            this.lblAncho.TabIndex = 4;
            this.lblAncho.Text = "Ancho de frente:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(5, 91);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 5;
            this.lblLegajo.Text = "Legajo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(44, 298);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(172, 298);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "&Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // rtxLista
            // 
            this.rtxLista.Location = new System.Drawing.Point(8, 142);
            this.rtxLista.Name = "rtxLista";
            this.rtxLista.Size = new System.Drawing.Size(272, 135);
            this.rtxLista.TabIndex = 8;
            this.rtxLista.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 333);
            this.Controls.Add(this.rtxLista);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtDirreccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirreccion;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.RichTextBox rtxLista;
    }
}

