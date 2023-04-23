namespace Tarea4
{
    partial class AddPelicula
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
            this.btAddPelicula = new System.Windows.Forms.Button();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbActor = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mcFechaActor = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddPelicula
            // 
            this.btAddPelicula.Location = new System.Drawing.Point(247, 513);
            this.btAddPelicula.Name = "btAddPelicula";
            this.btAddPelicula.Size = new System.Drawing.Size(113, 52);
            this.btAddPelicula.TabIndex = 0;
            this.btAddPelicula.Text = "Añadir";
            this.btAddPelicula.UseVisualStyleBackColor = true;
            this.btAddPelicula.Click += new System.EventHandler(this.btAddPelicula_Click);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(61, 22);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 23);
            this.tbTitulo.TabIndex = 1;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(61, 95);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(100, 23);
            this.tbDirector.TabIndex = 3;
            // 
            // tbActor
            // 
            this.tbActor.Location = new System.Drawing.Point(61, 39);
            this.tbActor.Name = "tbActor";
            this.tbActor.Size = new System.Drawing.Size(100, 23);
            this.tbActor.TabIndex = 7;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(61, 137);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 23);
            this.tbEstado.TabIndex = 4;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(61, 177);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 23);
            this.tbGenero.TabIndex = 6;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(61, 58);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 23);
            this.tbCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha Devolución";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Genero";
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(235, 30);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 16;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(61, 81);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 23);
            this.tbDNI.TabIndex = 8;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(501, 65);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(28, 23);
            this.tbEdad.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 20;
            this.label8.Tag = "";
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "DNI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Edad se calcula en automatico";
            // 
            // mcFechaActor
            // 
            this.mcFechaActor.Location = new System.Drawing.Point(234, 39);
            this.mcFechaActor.Name = "mcFechaActor";
            this.mcFechaActor.TabIndex = 23;
            this.mcFechaActor.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFechaActor_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbActor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mcFechaActor);
            this.groupBox1.Controls.Add(this.tbEdad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 245);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbGenero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mcFecha);
            this.groupBox2.Controls.Add(this.tbEstado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTitulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDirector);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 224);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pelicula";
            // 
            // AddPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAddPelicula);
            this.Name = "AddPelicula";
            this.Text = "Pelicula nueva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btAddPelicula;
        private TextBox tbTitulo;
        private TextBox tbDirector;
        private TextBox tbActor;
        private TextBox tbEstado;
        private TextBox tbGenero;
        private DateTimePicker dateTimePicker1;
        private TextBox tbCodigo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MonthCalendar mcFecha;
        private TextBox tbDNI;
        private TextBox tbEdad;
        private Label label8;
        private Label label9;
        private Label label10;
        private MonthCalendar mcFechaActor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}