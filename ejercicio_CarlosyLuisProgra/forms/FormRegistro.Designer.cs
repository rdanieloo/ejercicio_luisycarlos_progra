namespace ejercicio_luisycarlos_progra.forms
{
    partial class FormRegistro
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
            this.TituloEdad = new System.Windows.Forms.Label();
            this.IngresoEdad = new System.Windows.Forms.TextBox();
            this.IngresoNombre = new System.Windows.Forms.TextBox();
            this.TituloNombre = new System.Windows.Forms.Label();
            this.TituloFecha = new System.Windows.Forms.Label();
            this.IngresoFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TituloEdad
            // 
            this.TituloEdad.AutoSize = true;
            this.TituloEdad.Location = new System.Drawing.Point(57, 153);
            this.TituloEdad.Name = "TituloEdad";
            this.TituloEdad.Size = new System.Drawing.Size(82, 13);
            this.TituloEdad.TabIndex = 0;
            this.TituloEdad.Text = "ingrese su edad";
            // 
            // IngresoEdad
            // 
            this.IngresoEdad.Location = new System.Drawing.Point(239, 153);
            this.IngresoEdad.Name = "IngresoEdad";
            this.IngresoEdad.Size = new System.Drawing.Size(100, 20);
            this.IngresoEdad.TabIndex = 1;
            // 
            // IngresoNombre
            // 
            this.IngresoNombre.Location = new System.Drawing.Point(239, 106);
            this.IngresoNombre.Name = "IngresoNombre";
            this.IngresoNombre.Size = new System.Drawing.Size(100, 20);
            this.IngresoNombre.TabIndex = 3;
            // 
            // TituloNombre
            // 
            this.TituloNombre.AutoSize = true;
            this.TituloNombre.Location = new System.Drawing.Point(57, 106);
            this.TituloNombre.Name = "TituloNombre";
            this.TituloNombre.Size = new System.Drawing.Size(93, 13);
            this.TituloNombre.TabIndex = 2;
            this.TituloNombre.Text = "ingrese su nombre";
            // 
            // TituloFecha
            // 
            this.TituloFecha.AutoSize = true;
            this.TituloFecha.Location = new System.Drawing.Point(57, 204);
            this.TituloFecha.Name = "TituloFecha";
            this.TituloFecha.Size = new System.Drawing.Size(137, 13);
            this.TituloFecha.TabIndex = 4;
            this.TituloFecha.Text = "ingrese su fecha de ingreso";
            // 
            // IngresoFecha
            // 
            this.IngresoFecha.Location = new System.Drawing.Point(239, 204);
            this.IngresoFecha.Name = "IngresoFecha";
            this.IngresoFecha.Size = new System.Drawing.Size(200, 20);
            this.IngresoFecha.TabIndex = 5;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngresoFecha);
            this.Controls.Add(this.TituloFecha);
            this.Controls.Add(this.IngresoNombre);
            this.Controls.Add(this.TituloNombre);
            this.Controls.Add(this.IngresoEdad);
            this.Controls.Add(this.TituloEdad);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloEdad;
        private System.Windows.Forms.TextBox IngresoEdad;
        private System.Windows.Forms.TextBox IngresoNombre;
        private System.Windows.Forms.Label TituloNombre;
        private System.Windows.Forms.Label TituloFecha;
        private System.Windows.Forms.DateTimePicker IngresoFecha;
    }
}