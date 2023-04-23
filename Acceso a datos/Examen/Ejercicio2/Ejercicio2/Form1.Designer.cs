namespace Ejercicio2
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
            this.btActores = new System.Windows.Forms.Button();
            this.btPeliculas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btActores
            // 
            this.btActores.Location = new System.Drawing.Point(29, 26);
            this.btActores.Name = "btActores";
            this.btActores.Size = new System.Drawing.Size(140, 74);
            this.btActores.TabIndex = 0;
            this.btActores.Text = "ACTORES";
            this.btActores.UseVisualStyleBackColor = true;
            this.btActores.Click += new System.EventHandler(this.btActores_Click);
            // 
            // btPeliculas
            // 
            this.btPeliculas.Location = new System.Drawing.Point(230, 26);
            this.btPeliculas.Name = "btPeliculas";
            this.btPeliculas.Size = new System.Drawing.Size(150, 74);
            this.btPeliculas.TabIndex = 1;
            this.btPeliculas.Text = "PELICULAS";
            this.btPeliculas.UseVisualStyleBackColor = true;
            this.btPeliculas.Click += new System.EventHandler(this.btPeliculas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPeliculas);
            this.Controls.Add(this.btActores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btActores;
        private System.Windows.Forms.Button btPeliculas;
    }
}

