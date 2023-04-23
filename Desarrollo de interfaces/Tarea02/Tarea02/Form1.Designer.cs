namespace Tarea02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btagregarAlumno = new System.Windows.Forms.Button();
            this.lbAlumnosAsistentes = new System.Windows.Forms.ListBox();
            this.lbTotalAlumno = new System.Windows.Forms.ListBox();
            this.Asistentes = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btMueveTodosTotalAlumnos = new System.Windows.Forms.Button();
            this.btMueveTodosAsistente = new System.Windows.Forms.Button();
            this.btMueveUnoTotalAlumnos = new System.Windows.Forms.Button();
            this.btMueveUnAsistente = new System.Windows.Forms.Button();
            this.lbHistorico = new System.Windows.Forms.ListBox();
            this.dtFechaAsistencia = new System.Windows.Forms.DateTimePicker();
            this.btFinalizarAsistencia = new System.Windows.Forms.Button();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(149, 62);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 23);
            this.tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "APELLIDOS";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(149, 117);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 23);
            this.tbApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(149, 166);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 23);
            this.tbDni.TabIndex = 7;
            // 
            // btagregarAlumno
            // 
            this.btagregarAlumno.Location = new System.Drawing.Point(45, 260);
            this.btagregarAlumno.Name = "btagregarAlumno";
            this.btagregarAlumno.Size = new System.Drawing.Size(260, 23);
            this.btagregarAlumno.TabIndex = 11;
            this.btagregarAlumno.Text = "AGREGAR  ALUMNO";
            this.btagregarAlumno.UseVisualStyleBackColor = true;
            this.btagregarAlumno.Click += new System.EventHandler(this.btagregarAlumno_Click);
            // 
            // lbAlumnosAsistentes
            // 
            this.lbAlumnosAsistentes.FormattingEnabled = true;
            this.lbAlumnosAsistentes.ItemHeight = 15;
            this.lbAlumnosAsistentes.Location = new System.Drawing.Point(329, 48);
            this.lbAlumnosAsistentes.Name = "lbAlumnosAsistentes";
            this.lbAlumnosAsistentes.Size = new System.Drawing.Size(274, 244);
            this.lbAlumnosAsistentes.TabIndex = 12;
            // 
            // lbTotalAlumno
            // 
            this.lbTotalAlumno.FormattingEnabled = true;
            this.lbTotalAlumno.ItemHeight = 15;
            this.lbTotalAlumno.Location = new System.Drawing.Point(685, 48);
            this.lbTotalAlumno.Name = "lbTotalAlumno";
            this.lbTotalAlumno.Size = new System.Drawing.Size(287, 244);
            this.lbTotalAlumno.TabIndex = 13;
            // 
            // Asistentes
            // 
            this.Asistentes.AutoSize = true;
            this.Asistentes.Location = new System.Drawing.Point(429, 30);
            this.Asistentes.Name = "Asistentes";
            this.Asistentes.Size = new System.Drawing.Size(60, 15);
            this.Asistentes.TabIndex = 14;
            this.Asistentes.Text = "Asistentes";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(685, 30);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(97, 15);
            this.total.TabIndex = 15;
            this.total.Text = "Total de alumnos";
            // 
            // btMueveTodosTotalAlumnos
            // 
            this.btMueveTodosTotalAlumnos.Location = new System.Drawing.Point(624, 97);
            this.btMueveTodosTotalAlumnos.Name = "btMueveTodosTotalAlumnos";
            this.btMueveTodosTotalAlumnos.Size = new System.Drawing.Size(41, 36);
            this.btMueveTodosTotalAlumnos.TabIndex = 16;
            this.btMueveTodosTotalAlumnos.Text = "<<";
            this.btMueveTodosTotalAlumnos.UseVisualStyleBackColor = true;
            this.btMueveTodosTotalAlumnos.Click += new System.EventHandler(this.btMueveTodosTotalAlumnos_Click);
            // 
            // btMueveTodosAsistente
            // 
            this.btMueveTodosAsistente.Location = new System.Drawing.Point(624, 235);
            this.btMueveTodosAsistente.Name = "btMueveTodosAsistente";
            this.btMueveTodosAsistente.Size = new System.Drawing.Size(41, 30);
            this.btMueveTodosAsistente.TabIndex = 17;
            this.btMueveTodosAsistente.Text = ">>";
            this.btMueveTodosAsistente.UseVisualStyleBackColor = true;
            this.btMueveTodosAsistente.Click += new System.EventHandler(this.btMueveTodosAsistente_Click);
            // 
            // btMueveUnoTotalAlumnos
            // 
            this.btMueveUnoTotalAlumnos.Location = new System.Drawing.Point(624, 139);
            this.btMueveUnoTotalAlumnos.Name = "btMueveUnoTotalAlumnos";
            this.btMueveUnoTotalAlumnos.Size = new System.Drawing.Size(41, 36);
            this.btMueveUnoTotalAlumnos.TabIndex = 18;
            this.btMueveUnoTotalAlumnos.Text = "<";
            this.btMueveUnoTotalAlumnos.UseVisualStyleBackColor = true;
            this.btMueveUnoTotalAlumnos.Click += new System.EventHandler(this.btMueveUnoTotalAlumnos_Click);
            // 
            // btMueveUnAsistente
            // 
            this.btMueveUnAsistente.Location = new System.Drawing.Point(624, 189);
            this.btMueveUnAsistente.Name = "btMueveUnAsistente";
            this.btMueveUnAsistente.Size = new System.Drawing.Size(41, 36);
            this.btMueveUnAsistente.TabIndex = 19;
            this.btMueveUnAsistente.Text = ">";
            this.btMueveUnAsistente.UseVisualStyleBackColor = true;
            this.btMueveUnAsistente.Click += new System.EventHandler(this.btMueveUnAsistente_Click);
            // 
            // lbHistorico
            // 
            this.lbHistorico.FormattingEnabled = true;
            this.lbHistorico.ItemHeight = 15;
            this.lbHistorico.Location = new System.Drawing.Point(69, 412);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(903, 94);
            this.lbHistorico.TabIndex = 20;
            // 
            // dtFechaAsistencia
            // 
            this.dtFechaAsistencia.Location = new System.Drawing.Point(988, 52);
            this.dtFechaAsistencia.Name = "dtFechaAsistencia";
            this.dtFechaAsistencia.Size = new System.Drawing.Size(222, 23);
            this.dtFechaAsistencia.TabIndex = 21;
            // 
            // btFinalizarAsistencia
            // 
            this.btFinalizarAsistencia.Location = new System.Drawing.Point(1019, 113);
            this.btFinalizarAsistencia.Name = "btFinalizarAsistencia";
            this.btFinalizarAsistencia.Size = new System.Drawing.Size(191, 98);
            this.btFinalizarAsistencia.TabIndex = 22;
            this.btFinalizarAsistencia.Text = "Finalizar Asistencia";
            this.btFinalizarAsistencia.UseVisualStyleBackColor = true;
            this.btFinalizarAsistencia.Click += new System.EventHandler(this.btFinalizarAsistencia_Click);
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "1ªDAM",
            "2ªDAM"});
            this.cbCurso.Location = new System.Drawing.Point(149, 210);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(100, 23);
            this.cbCurso.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "CURSO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 646);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.btFinalizarAsistencia);
            this.Controls.Add(this.dtFechaAsistencia);
            this.Controls.Add(this.lbHistorico);
            this.Controls.Add(this.btMueveUnAsistente);
            this.Controls.Add(this.btMueveUnoTotalAlumnos);
            this.Controls.Add(this.btMueveTodosAsistente);
            this.Controls.Add(this.btMueveTodosTotalAlumnos);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Asistentes);
            this.Controls.Add(this.lbTotalAlumno);
            this.Controls.Add(this.lbAlumnosAsistentes);
            this.Controls.Add(this.btagregarAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Label label2;
        private TextBox tbApellidos;
        private Label label3;
        private TextBox tbDni;
        private Button btagregarAlumno;
        private ListBox lbAlumnosAsistentes;
        private ListBox lbTotalAlumno;
        private Label Asistentes;
        private Label total;
        private Button btMueveTodosTotalAlumnos;
        private Button btMueveTodosAsistente;
        private Button btMueveUnoTotalAlumnos;
        private Button btMueveUnAsistente;
        private ListBox lbHistorico;
        private DateTimePicker dtFechaAsistencia;
        private Button btFinalizarAsistencia;
        private ComboBox cbCurso;
        private Label label4;
    }
}