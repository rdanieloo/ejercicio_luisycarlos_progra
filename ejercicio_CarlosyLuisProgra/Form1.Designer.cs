namespace ejercicio_luisycarlos_progra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CredencialesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Validate = new System.Windows.Forms.Button();
            this.UserInputName = new System.Windows.Forms.TextBox();
            this.UserInputPass = new System.Windows.Forms.TextBox();
            this.intentos = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CredencialesLabel
            // 
            this.CredencialesLabel.AutoSize = true;
            this.CredencialesLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.CredencialesLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CredencialesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CredencialesLabel.Location = new System.Drawing.Point(165, 14);
            this.CredencialesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CredencialesLabel.Name = "CredencialesLabel";
            this.CredencialesLabel.Size = new System.Drawing.Size(579, 69);
            this.CredencialesLabel.TabIndex = 0;
            this.CredencialesLabel.Text = "ingrese sus credenciales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "usuario";
            // 
            // Validate
            // 
            this.Validate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Validate.Location = new System.Drawing.Point(406, 592);
            this.Validate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(282, 69);
            this.Validate.TabIndex = 3;
            this.Validate.Text = "Ingresar";
            this.Validate.UseVisualStyleBackColor = false;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // UserInputName
            // 
            this.UserInputName.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputName.Location = new System.Drawing.Point(406, 162);
            this.UserInputName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserInputName.Name = "UserInputName";
            this.UserInputName.Size = new System.Drawing.Size(500, 68);
            this.UserInputName.TabIndex = 4;
            // 
            // UserInputPass
            // 
            this.UserInputPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputPass.Location = new System.Drawing.Point(406, 338);
            this.UserInputPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserInputPass.Name = "UserInputPass";
            this.UserInputPass.PasswordChar = '?';
            this.UserInputPass.Size = new System.Drawing.Size(500, 68);
            this.UserInputPass.TabIndex = 5;
            // 
            // intentos
            // 
            this.intentos.AutoSize = true;
            this.intentos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.intentos.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.ForeColor = System.Drawing.SystemColors.Control;
            this.intentos.Location = new System.Drawing.Point(20, 592);
            this.intentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(171, 46);
            this.intentos.TabIndex = 6;
            this.intentos.Text = "intentos ";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.counter.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(198, 592);
            this.counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(37, 40);
            this.counter.TabIndex = 7;
            this.counter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(21, 646);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "maximo de intentos: 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1092, 680);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.UserInputPass);
            this.Controls.Add(this.UserInputName);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CredencialesLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "App by Carlos & Luis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CredencialesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.TextBox UserInputName;
        private System.Windows.Forms.TextBox UserInputPass;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label label3;
    }
}

