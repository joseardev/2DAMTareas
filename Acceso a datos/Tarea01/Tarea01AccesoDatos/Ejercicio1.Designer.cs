namespace Tarea01AccesoDatos
{
    partial class Ejercicio1
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
            this.btLeer = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.tbModificarFichero = new System.Windows.Forms.TextBox();
            this.lbLineasFichero = new System.Windows.Forms.ListBox();
            this.btAbrirFichero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLineaNueva = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(12, 355);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(295, 61);
            this.btLeer.TabIndex = 1;
            this.btLeer.Text = "Leer Fichero";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(13, 35);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(295, 67);
            this.btModificar.TabIndex = 2;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // tbModificarFichero
            // 
            this.tbModificarFichero.AcceptsReturn = true;
            this.tbModificarFichero.AcceptsTab = true;
            this.tbModificarFichero.Location = new System.Drawing.Point(436, 38);
            this.tbModificarFichero.Multiline = true;
            this.tbModificarFichero.Name = "tbModificarFichero";
            this.tbModificarFichero.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbModificarFichero.Size = new System.Drawing.Size(243, 172);
            this.tbModificarFichero.TabIndex = 4;
            // 
            // lbLineasFichero
            // 
            this.lbLineasFichero.FormattingEnabled = true;
            this.lbLineasFichero.ItemHeight = 15;
            this.lbLineasFichero.Location = new System.Drawing.Point(448, 355);
            this.lbLineasFichero.Name = "lbLineasFichero";
            this.lbLineasFichero.Size = new System.Drawing.Size(243, 214);
            this.lbLineasFichero.TabIndex = 5;
            // 
            // btAbrirFichero
            // 
            this.btAbrirFichero.Location = new System.Drawing.Point(25, 505);
            this.btAbrirFichero.Name = "btAbrirFichero";
            this.btAbrirFichero.Size = new System.Drawing.Size(169, 48);
            this.btAbrirFichero.TabIndex = 6;
            this.btAbrirFichero.Text = "Abrir Fichero";
            this.btAbrirFichero.UseVisualStyleBackColor = true;
            this.btAbrirFichero.Click += new System.EventHandler(this.btAbrirFichero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLineaNueva);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 103);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guardar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Linea nueva";
            // 
            // tbLineaNueva
            // 
            this.tbLineaNueva.Location = new System.Drawing.Point(314, 44);
            this.tbLineaNueva.Name = "tbLineaNueva";
            this.tbLineaNueva.Size = new System.Drawing.Size(365, 23);
            this.tbLineaNueva.TabIndex = 9;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(13, 19);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(295, 71);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btModificar);
            this.groupBox2.Controls.Add(this.tbModificarFichero);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 216);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modificar texto aqui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lectura Fichero";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAbrirFichero);
            this.Controls.Add(this.lbLineasFichero);
            this.Controls.Add(this.btLeer);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btLeer;
        private Button btModificar;
        private TextBox tbModificarFichero;
        private ListBox lbLineasFichero;
        private Button btAbrirFichero;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbLineaNueva;
        private Button btGuardar;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
    }
}