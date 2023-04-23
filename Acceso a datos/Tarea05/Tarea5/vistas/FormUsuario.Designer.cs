namespace Tarea5.vistas
{
    partial class FormUsuario
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
            this.components = new System.ComponentModel.Container();
            this.dgwUsuario = new System.Windows.Forms.DataGridView();
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
            this.btCrearUsuario = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUsuario
            // 
            this.dgwUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuario.Location = new System.Drawing.Point(222, 12);
            this.dgwUsuario.Name = "dgwUsuario";
            this.dgwUsuario.Size = new System.Drawing.Size(942, 468);
            this.dgwUsuario.TabIndex = 0;
            this.dgwUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre usuario";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(102, 29);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbNombreUsuario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(102, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(26, 110);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 12;
            this.Contraseña.Text = "Contraseña";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(102, 107);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(102, 148);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(102, 185);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 15;
            // 
            // btCrearUsuario
            // 
            this.btCrearUsuario.Location = new System.Drawing.Point(48, 237);
            this.btCrearUsuario.Name = "btCrearUsuario";
            this.btCrearUsuario.Size = new System.Drawing.Size(154, 50);
            this.btCrearUsuario.TabIndex = 17;
            this.btCrearUsuario.Text = "Crear Usuario";
            this.btCrearUsuario.UseVisualStyleBackColor = true;
            this.btCrearUsuario.Click += new System.EventHandler(this.btCrearUsuario_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Tarea5.Entidades.Usuario);
            // 
            // btRefrescar
            // 
            this.btRefrescar.Location = new System.Drawing.Point(222, 483);
            this.btRefrescar.Name = "btRefrescar";
            this.btRefrescar.Size = new System.Drawing.Size(123, 23);
            this.btRefrescar.TabIndex = 18;
            this.btRefrescar.Text = "REFRESCAR";
            this.btRefrescar.UseVisualStyleBackColor = true;
            this.btRefrescar.Click += new System.EventHandler(this.btRefrescar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 518);
            this.Controls.Add(this.btRefrescar);
            this.Controls.Add(this.btCrearUsuario);
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
            this.Controls.Add(this.dgwUsuario);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView dgwUsuario;
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
        private System.Windows.Forms.Button btCrearUsuario;
        private System.Windows.Forms.Button btRefrescar;
    }
}