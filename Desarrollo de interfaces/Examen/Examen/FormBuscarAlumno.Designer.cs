namespace Examen
{
    partial class FormBuscarAlumno
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
            this.btBuscarInstituto = new System.Windows.Forms.Button();
            this.cbNombreInstitutos = new System.Windows.Forms.ComboBox();
            this.ListaAlumnosInstituto = new System.Windows.Forms.ListBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombreAlumno = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbDniAlumno = new System.Windows.Forms.TextBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbNotaMedia = new System.Windows.Forms.TextBox();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btModificarAlumno = new System.Windows.Forms.Button();
            this.btBorrarAlumno = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscarInstituto
            // 
            this.btBuscarInstituto.Location = new System.Drawing.Point(12, 69);
            this.btBuscarInstituto.Name = "btBuscarInstituto";
            this.btBuscarInstituto.Size = new System.Drawing.Size(133, 23);
            this.btBuscarInstituto.TabIndex = 0;
            this.btBuscarInstituto.Text = "buscar Instituto";
            this.btBuscarInstituto.UseVisualStyleBackColor = true;
            this.btBuscarInstituto.Click += new System.EventHandler(this.btBuscarInstituto_Click);
            // 
            // cbNombreInstitutos
            // 
            this.cbNombreInstitutos.FormattingEnabled = true;
            this.cbNombreInstitutos.Location = new System.Drawing.Point(181, 69);
            this.cbNombreInstitutos.Name = "cbNombreInstitutos";
            this.cbNombreInstitutos.Size = new System.Drawing.Size(121, 23);
            this.cbNombreInstitutos.TabIndex = 2;
            // 
            // ListaAlumnosInstituto
            // 
            this.ListaAlumnosInstituto.FormattingEnabled = true;
            this.ListaAlumnosInstituto.ItemHeight = 15;
            this.ListaAlumnosInstituto.Location = new System.Drawing.Point(379, 27);
            this.ListaAlumnosInstituto.Name = "ListaAlumnosInstituto";
            this.ListaAlumnosInstituto.Size = new System.Drawing.Size(797, 199);
            this.ListaAlumnosInstituto.TabIndex = 3;
            this.ListaAlumnosInstituto.SelectedIndexChanged += new System.EventHandler(this.ListaAlumnosInstituto_SelectedIndexChanged);
            this.ListaAlumnosInstituto.DoubleClick += new System.EventHandler(this.ListaAlumnosInstituto_DoubleClick);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(181, 116);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(121, 23);
            this.tbDni.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "buscar por DNI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombreAlumno
            // 
            this.tbNombreAlumno.Location = new System.Drawing.Point(181, 247);
            this.tbNombreAlumno.Name = "tbNombreAlumno";
            this.tbNombreAlumno.Size = new System.Drawing.Size(100, 23);
            this.tbNombreAlumno.TabIndex = 6;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(181, 300);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 23);
            this.tbApellidos.TabIndex = 7;
            // 
            // tbDniAlumno
            // 
            this.tbDniAlumno.Location = new System.Drawing.Point(181, 357);
            this.tbDniAlumno.Name = "tbDniAlumno";
            this.tbDniAlumno.Size = new System.Drawing.Size(100, 23);
            this.tbDniAlumno.TabIndex = 8;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(181, 412);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtFechaNacimiento.TabIndex = 9;
            // 
            // tbNotaMedia
            // 
            this.tbNotaMedia.Location = new System.Drawing.Point(181, 503);
            this.tbNotaMedia.Name = "tbNotaMedia";
            this.tbNotaMedia.Size = new System.Drawing.Size(100, 23);
            this.tbNotaMedia.TabIndex = 11;
            // 
            // tbCurso
            // 
            this.tbCurso.Location = new System.Drawing.Point(181, 456);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(141, 23);
            this.tbCurso.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "fecha nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "nota media";
            // 
            // btModificarAlumno
            // 
            this.btModificarAlumno.Location = new System.Drawing.Point(456, 357);
            this.btModificarAlumno.Name = "btModificarAlumno";
            this.btModificarAlumno.Size = new System.Drawing.Size(210, 92);
            this.btModificarAlumno.TabIndex = 20;
            this.btModificarAlumno.Text = "Modificar Alumno";
            this.btModificarAlumno.UseVisualStyleBackColor = true;
            this.btModificarAlumno.Click += new System.EventHandler(this.btModificarAlumno_Click);
            // 
            // btBorrarAlumno
            // 
            this.btBorrarAlumno.Location = new System.Drawing.Point(687, 357);
            this.btBorrarAlumno.Name = "btBorrarAlumno";
            this.btBorrarAlumno.Size = new System.Drawing.Size(210, 91);
            this.btBorrarAlumno.TabIndex = 21;
            this.btBorrarAlumno.Text = "Borrar Alumno";
            this.btBorrarAlumno.UseVisualStyleBackColor = true;
            this.btBorrarAlumno.Click += new System.EventHandler(this.btBorrarAlumno_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "La ventana model se abre al hacer doble click n el alumno";
            // 
            // FormBuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 586);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btBorrarAlumno);
            this.Controls.Add(this.btModificarAlumno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurso);
            this.Controls.Add(this.tbNotaMedia);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.tbDniAlumno);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombreAlumno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.ListaAlumnosInstituto);
            this.Controls.Add(this.cbNombreInstitutos);
            this.Controls.Add(this.btBuscarInstituto);
            this.Name = "FormBuscarAlumno";
            this.Text = "buscar alumno";
            this.Load += new System.EventHandler(this.FormBuscarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btBuscarInstituto;
        private ComboBox cbNombreInstitutos;
        private ListBox ListaAlumnosInstituto;
        private TextBox tbDni;
        private Button button1;
        private TextBox tbNombreAlumno;
        private TextBox tbApellidos;
        private TextBox tbDniAlumno;
        private DateTimePicker dtFechaNacimiento;
        private TextBox tbNotaMedia;
        private TextBox tbCurso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btModificarAlumno;
        private Button btBorrarAlumno;
        private Label label7;
    }
}