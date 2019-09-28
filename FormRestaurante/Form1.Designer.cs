namespace FormRestaurante
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
            this.label1 = new System.Windows.Forms.Label();
            this.nuevoRegistro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.pbIniciarSesion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(226, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // nuevoRegistro
            // 
            this.nuevoRegistro.AutoSize = true;
            this.nuevoRegistro.BackColor = System.Drawing.Color.Transparent;
            this.nuevoRegistro.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.nuevoRegistro.LinkColor = System.Drawing.Color.White;
            this.nuevoRegistro.Location = new System.Drawing.Point(227, 284);
            this.nuevoRegistro.Name = "nuevoRegistro";
            this.nuevoRegistro.Size = new System.Drawing.Size(221, 18);
            this.nuevoRegistro.TabIndex = 1;
            this.nuevoRegistro.TabStop = true;
            this.nuevoRegistro.Text = "¿Aún no tienes cuenta? Regístrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(191, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(306, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(306, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassword.Font = new System.Drawing.Font("Ubuntu", 10F);
            this.forgotPassword.LinkColor = System.Drawing.Color.White;
            this.forgotPassword.Location = new System.Drawing.Point(249, 312);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(169, 18);
            this.forgotPassword.TabIndex = 5;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "¿Olvidaste tu contraseña?";
            // 
            // pbIniciarSesion
            // 
            this.pbIniciarSesion.BackgroundImage = global::FormRestaurante.Properties.Resources.btnIniciarSesion;
            this.pbIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIniciarSesion.Location = new System.Drawing.Point(214, 217);
            this.pbIniciarSesion.Name = "pbIniciarSesion";
            this.pbIniciarSesion.Size = new System.Drawing.Size(261, 52);
            this.pbIniciarSesion.TabIndex = 8;
            this.pbIniciarSesion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FormRestaurante.Properties.Resources.Wings_Planet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.pbIniciarSesion);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuevoRegistro);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Alitas";
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciarSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel nuevoRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel forgotPassword;
        private System.Windows.Forms.PictureBox pbIniciarSesion;
    }
}

