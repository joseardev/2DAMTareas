namespace Tarea03DesarrolloInterfaces
{
    partial class AddContacto
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
            this.btAddUsuario = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.cbEstudios = new System.Windows.Forms.ComboBox();
            this.cbLudopatia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAddUsuario
            // 
            this.btAddUsuario.Location = new System.Drawing.Point(143, 218);
            this.btAddUsuario.Name = "btAddUsuario";
            this.btAddUsuario.Size = new System.Drawing.Size(75, 23);
            this.btAddUsuario.TabIndex = 0;
            this.btAddUsuario.Text = "Añadir";
            this.btAddUsuario.UseVisualStyleBackColor = true;
            this.btAddUsuario.Click += new System.EventHandler(this.btAddUsuario_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(132, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 23);
            this.tbNombre.TabIndex = 1;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(132, 44);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 23);
            this.tbApellidos.TabIndex = 2;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(132, 73);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 23);
            this.tbTelefono.TabIndex = 3;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(132, 104);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 23);
            this.tbDni.TabIndex = 4;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(132, 133);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(100, 23);
            this.tbSexo.TabIndex = 5;
            // 
            // cbEstudios
            // 
            this.cbEstudios.FormattingEnabled = true;
            this.cbEstudios.Items.AddRange(new object[] {
            "ESO",
            "Bachiller",
            "FP",
            "Universidad"});
            this.cbEstudios.Location = new System.Drawing.Point(132, 160);
            this.cbEstudios.Name = "cbEstudios";
            this.cbEstudios.Size = new System.Drawing.Size(121, 23);
            this.cbEstudios.TabIndex = 32;
            // 
            // cbLudopatia
            // 
            this.cbLudopatia.FormattingEnabled = true;
            this.cbLudopatia.Items.AddRange(new object[] {
            "Tabaco",
            "Alcohol",
            "Ludopatía"});
            this.cbLudopatia.Location = new System.Drawing.Point(132, 189);
            this.cbLudopatia.Name = "cbLudopatia";
            this.cbLudopatia.Size = new System.Drawing.Size(121, 23);
            this.cbLudopatia.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Vicios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nivel de estudios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // AddContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 268);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLudopatia);
            this.Controls.Add(this.cbEstudios);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btAddUsuario);
            this.Name = "AddContacto";
            this.Text = "Añadir Contacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAddUsuario;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbTelefono;
        private TextBox tbDni;
        private TextBox tbSexo;
        private ComboBox cbEstudios;
        private ComboBox cbLudopatia;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}