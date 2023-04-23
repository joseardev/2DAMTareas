namespace Tarea4
{
    partial class EditarPelicula
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
            this.btEditar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbActor = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(12, 270);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(168, 35);
            this.btEditar.TabIndex = 0;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(80, 58);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 23);
            this.tbCodigo.TabIndex = 15;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(80, 224);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 23);
            this.tbGenero.TabIndex = 13;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(80, 189);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 23);
            this.tbEstado.TabIndex = 12;
            // 
            // tbActor
            // 
            this.tbActor.Location = new System.Drawing.Point(80, 147);
            this.tbActor.Name = "tbActor";
            this.tbActor.Size = new System.Drawing.Size(100, 23);
            this.tbActor.TabIndex = 11;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(80, 103);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(100, 23);
            this.tbDirector.TabIndex = 10;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(80, 14);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 23);
            this.tbTitulo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Actor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Director";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Titulo";
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(250, 40);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Devolución";
            // 
            // EditarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbActor);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.btEditar);
            this.Name = "EditarPelicula";
            this.Text = "Editar Pelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btEditar;
        private TextBox tbCodigo;
        private DateTimePicker dtFechaDevolucion;
        private TextBox tbGenero;
        private TextBox tbEstado;
        private TextBox tbActor;
        private TextBox tbDirector;
        private TextBox tbTitulo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MonthCalendar mcFecha;
        private Label label8;
    }
}