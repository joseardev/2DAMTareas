namespace Examen
{
    partial class FormAddAlumno
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
            this.tbNombreAlumno = new System.Windows.Forms.TextBox();
            this.tbApellidosAlumno = new System.Windows.Forms.TextBox();
            this.tbDniAlumno = new System.Windows.Forms.TextBox();
            this.mcFechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.tbNotaMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInstitutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btAddAlumnoNuevo = new System.Windows.Forms.Button();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbNombreAlumno
            // 
            this.tbNombreAlumno.Location = new System.Drawing.Point(104, 20);
            this.tbNombreAlumno.Name = "tbNombreAlumno";
            this.tbNombreAlumno.Size = new System.Drawing.Size(100, 23);
            this.tbNombreAlumno.TabIndex = 0;
            // 
            // tbApellidosAlumno
            // 
            this.tbApellidosAlumno.Location = new System.Drawing.Point(104, 60);
            this.tbApellidosAlumno.Name = "tbApellidosAlumno";
            this.tbApellidosAlumno.Size = new System.Drawing.Size(100, 23);
            this.tbApellidosAlumno.TabIndex = 1;
            // 
            // tbDniAlumno
            // 
            this.tbDniAlumno.Location = new System.Drawing.Point(99, 100);
            this.tbDniAlumno.Name = "tbDniAlumno";
            this.tbDniAlumno.Size = new System.Drawing.Size(100, 23);
            this.tbDniAlumno.TabIndex = 2;
            // 
            // mcFechaNacimiento
            // 
            this.mcFechaNacimiento.Location = new System.Drawing.Point(128, 135);
            this.mcFechaNacimiento.Name = "mcFechaNacimiento";
            this.mcFechaNacimiento.TabIndex = 4;
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Items.AddRange(new object[] {
            "1ºDAM",
            "1ºDAW",
            "2ºDAM",
            "2ºDAW"});
            this.cbCursos.Location = new System.Drawing.Point(115, 370);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 23);
            this.cbCursos.TabIndex = 6;
            // 
            // tbNotaMedia
            // 
            this.tbNotaMedia.Location = new System.Drawing.Point(115, 415);
            this.tbNotaMedia.Name = "tbNotaMedia";
            this.tbNotaMedia.Size = new System.Drawing.Size(100, 23);
            this.tbNotaMedia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellidos";
            // 
            // cbInstitutos
            // 
            this.cbInstitutos.FormattingEnabled = true;
            this.cbInstitutos.Location = new System.Drawing.Point(115, 318);
            this.cbInstitutos.Name = "cbInstitutos";
            this.cbInstitutos.Size = new System.Drawing.Size(121, 23);
            this.cbInstitutos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Instituto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nota Media";
            // 
            // btAddAlumnoNuevo
            // 
            this.btAddAlumnoNuevo.Location = new System.Drawing.Point(427, 23);
            this.btAddAlumnoNuevo.Name = "btAddAlumnoNuevo";
            this.btAddAlumnoNuevo.Size = new System.Drawing.Size(176, 136);
            this.btAddAlumnoNuevo.TabIndex = 18;
            this.btAddAlumnoNuevo.Text = "Añadir Alumno";
            this.btAddAlumnoNuevo.UseVisualStyleBackColor = true;
            this.btAddAlumnoNuevo.Click += new System.EventHandler(this.btAddAlumnoNuevo_Click);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(455, 212);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtFechaNacimiento.TabIndex = 19;
            // 
            // FormAddAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.btAddAlumnoNuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbInstitutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotaMedia);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.mcFechaNacimiento);
            this.Controls.Add(this.tbDniAlumno);
            this.Controls.Add(this.tbApellidosAlumno);
            this.Controls.Add(this.tbNombreAlumno);
            this.Name = "FormAddAlumno";
            this.Text = "FormAddAlumno";
            this.Load += new System.EventHandler(this.FormAddAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNombreAlumno;
        private TextBox tbApellidosAlumno;
        private TextBox tbDniAlumno;
        private MonthCalendar mcFechaNacimiento;
        private ComboBox cbCursos;
        private TextBox tbNotaMedia;
        private Label label1;
        private Label label2;
        private ComboBox cbInstitutos;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btAddAlumnoNuevo;
        private DateTimePicker dtFechaNacimiento;
    }
}