namespace Tarea5.vistas
{
    partial class FormModificarUsuario
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
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.btModficarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre usuario";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(118, 27);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbNombreUsuario.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(118, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(42, 106);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 14;
            this.Contraseña.Text = "Contraseña";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(118, 103);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(118, 146);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(118, 190);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 17;
            // 
            // btModficarUsuario
            // 
            this.btModficarUsuario.Location = new System.Drawing.Point(28, 252);
            this.btModficarUsuario.Name = "btModficarUsuario";
            this.btModficarUsuario.Size = new System.Drawing.Size(211, 70);
            this.btModficarUsuario.TabIndex = 19;
            this.btModficarUsuario.Text = "GUARDAR";
            this.btModficarUsuario.UseVisualStyleBackColor = true;
            this.btModficarUsuario.Click += new System.EventHandler(this.btModficarUsuario_Click);
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 379);
            this.Controls.Add(this.btModficarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreUsuario);
            this.Name = "FormModificarUsuario";
            this.Text = "FormModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Button btModficarUsuario;
    }
}