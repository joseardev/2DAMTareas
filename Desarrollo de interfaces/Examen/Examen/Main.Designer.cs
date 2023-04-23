namespace Examen
{
    partial class Main
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
            this.btAddAlumno = new System.Windows.Forms.Button();
            this.btAddInstituto = new System.Windows.Forms.Button();
            this.btBuscarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAddAlumno
            // 
            this.btAddAlumno.Location = new System.Drawing.Point(43, 32);
            this.btAddAlumno.Name = "btAddAlumno";
            this.btAddAlumno.Size = new System.Drawing.Size(102, 23);
            this.btAddAlumno.TabIndex = 0;
            this.btAddAlumno.Text = "Añadir alumno";
            this.btAddAlumno.UseVisualStyleBackColor = true;
            this.btAddAlumno.Click += new System.EventHandler(this.btAddAlumno_Click);
            // 
            // btAddInstituto
            // 
            this.btAddInstituto.Location = new System.Drawing.Point(434, 32);
            this.btAddInstituto.Name = "btAddInstituto";
            this.btAddInstituto.Size = new System.Drawing.Size(115, 23);
            this.btAddInstituto.TabIndex = 1;
            this.btAddInstituto.Text = "Añadir Instituto";
            this.btAddInstituto.UseVisualStyleBackColor = true;
            this.btAddInstituto.Click += new System.EventHandler(this.btAddInstituto_Click);
            // 
            // btBuscarAlumno
            // 
            this.btBuscarAlumno.Location = new System.Drawing.Point(43, 78);
            this.btBuscarAlumno.Name = "btBuscarAlumno";
            this.btBuscarAlumno.Size = new System.Drawing.Size(102, 23);
            this.btBuscarAlumno.TabIndex = 2;
            this.btBuscarAlumno.Text = "buscar Alumno";
            this.btBuscarAlumno.UseVisualStyleBackColor = true;
            this.btBuscarAlumno.Click += new System.EventHandler(this.btBuscarAlumno_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscarAlumno);
            this.Controls.Add(this.btAddInstituto);
            this.Controls.Add(this.btAddAlumno);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btAddAlumno;
        private Button btAddInstituto;
        private Button btBuscarAlumno;
    }
}