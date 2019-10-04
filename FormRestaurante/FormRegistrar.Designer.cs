namespace FormRestaurante
{
    partial class FormRegistrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbConfirmacionContraseña = new System.Windows.Forms.TextBox();
            this.txtbRespuesta = new System.Windows.Forms.TextBox();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lknIngresar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(291, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(294, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(s)*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(315, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(233, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo electrónico*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(224, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de teléfono*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(247, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pregunta secreta*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(281, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Su respuesta*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(289, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Contraseña*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(211, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Confirmar contraseña*";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(473, 96);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(198, 20);
            this.txtbNombre.TabIndex = 6;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(473, 133);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(198, 20);
            this.txtbApellido.TabIndex = 6;
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(473, 165);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(198, 20);
            this.txtbCorreo.TabIndex = 6;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(473, 204);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(198, 20);
            this.txtbTelefono.TabIndex = 6;
            this.txtbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbTelefono_KeyPress);
            // 
            // txtbConfirmacionContraseña
            // 
            this.txtbConfirmacionContraseña.Location = new System.Drawing.Point(473, 367);
            this.txtbConfirmacionContraseña.Name = "txtbConfirmacionContraseña";
            this.txtbConfirmacionContraseña.Size = new System.Drawing.Size(198, 20);
            this.txtbConfirmacionContraseña.TabIndex = 6;
            // 
            // txtbRespuesta
            // 
            this.txtbRespuesta.Location = new System.Drawing.Point(473, 284);
            this.txtbRespuesta.Name = "txtbRespuesta";
            this.txtbRespuesta.Size = new System.Drawing.Size(198, 20);
            this.txtbRespuesta.TabIndex = 6;
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.Items.AddRange(new object[] {
            "Mascota Favorita",
            "Sabor de alitas favorito",
            "Color Favorito",
            "Universidad",
            "Cerveza favorita"});
            this.cmbPregunta.Location = new System.Drawing.Point(473, 245);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(198, 21);
            this.cmbPregunta.TabIndex = 7;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(473, 326);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(198, 20);
            this.txtbContraseña.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(248, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "*Campos Obligatorios";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(361, 462);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(198, 47);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(326, 522);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "¿Ya tienes una cuenta?";
            // 
            // lknIngresar
            // 
            this.lknIngresar.AutoSize = true;
            this.lknIngresar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lknIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lknIngresar.LinkColor = System.Drawing.Color.White;
            this.lknIngresar.Location = new System.Drawing.Point(509, 522);
            this.lknIngresar.Name = "lknIngresar";
            this.lknIngresar.Size = new System.Drawing.Size(72, 23);
            this.lknIngresar.TabIndex = 11;
            this.lknIngresar.TabStop = true;
            this.lknIngresar.Text = "Ingresar";
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lknIngresar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.txtbRespuesta);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.txtbConfirmacionContraseña);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbCorreo);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.Load += new System.EventHandler(this.FormRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbCorreo;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbConfirmacionContraseña;
        private System.Windows.Forms.TextBox txtbRespuesta;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lknIngresar;
    }
}