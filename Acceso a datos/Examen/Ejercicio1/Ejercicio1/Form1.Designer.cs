namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCargarFicheros = new System.Windows.Forms.Button();
            this.tbRutaNominas = new System.Windows.Forms.TextBox();
            this.lbFicherosCargados = new System.Windows.Forms.ListBox();
            this.lbDatosFicheros = new System.Windows.Forms.ListBox();
            this.lbNominasGuardadas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCargarFicheros
            // 
            this.btCargarFicheros.Location = new System.Drawing.Point(52, 51);
            this.btCargarFicheros.Name = "btCargarFicheros";
            this.btCargarFicheros.Size = new System.Drawing.Size(173, 23);
            this.btCargarFicheros.TabIndex = 0;
            this.btCargarFicheros.Text = "Cargar de Nominas";
            this.btCargarFicheros.UseVisualStyleBackColor = true;
            this.btCargarFicheros.Click += new System.EventHandler(this.btCargarFicheros_Click);
            // 
            // tbRutaNominas
            // 
            this.tbRutaNominas.Location = new System.Drawing.Point(231, 51);
            this.tbRutaNominas.Name = "tbRutaNominas";
            this.tbRutaNominas.Size = new System.Drawing.Size(544, 20);
            this.tbRutaNominas.TabIndex = 1;
            // 
            // lbFicherosCargados
            // 
            this.lbFicherosCargados.FormattingEnabled = true;
            this.lbFicherosCargados.Location = new System.Drawing.Point(52, 114);
            this.lbFicherosCargados.Name = "lbFicherosCargados";
            this.lbFicherosCargados.Size = new System.Drawing.Size(164, 355);
            this.lbFicherosCargados.TabIndex = 2;
            // 
            // lbDatosFicheros
            // 
            this.lbDatosFicheros.FormattingEnabled = true;
            this.lbDatosFicheros.Location = new System.Drawing.Point(263, 114);
            this.lbDatosFicheros.Name = "lbDatosFicheros";
            this.lbDatosFicheros.Size = new System.Drawing.Size(479, 355);
            this.lbDatosFicheros.TabIndex = 3;
            // 
            // lbNominasGuardadas
            // 
            this.lbNominasGuardadas.FormattingEnabled = true;
            this.lbNominasGuardadas.Location = new System.Drawing.Point(863, 114);
            this.lbNominasGuardadas.Name = "lbNominasGuardadas";
            this.lbNominasGuardadas.Size = new System.Drawing.Size(380, 355);
            this.lbNominasGuardadas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Creados base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ficheros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos de los ficheros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNominasGuardadas);
            this.Controls.Add(this.lbDatosFicheros);
            this.Controls.Add(this.lbFicherosCargados);
            this.Controls.Add(this.tbRutaNominas);
            this.Controls.Add(this.btCargarFicheros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCargarFicheros;
        private System.Windows.Forms.TextBox tbRutaNominas;
        private System.Windows.Forms.ListBox lbFicherosCargados;
        private System.Windows.Forms.ListBox lbDatosFicheros;
        private System.Windows.Forms.ListBox lbNominasGuardadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

