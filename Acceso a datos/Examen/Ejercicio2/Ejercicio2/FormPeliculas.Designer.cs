namespace Ejercicio2
{
    partial class FormPeliculas
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
            this.lbListaPeliculas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbListaPeliculas
            // 
            this.lbListaPeliculas.FormattingEnabled = true;
            this.lbListaPeliculas.Location = new System.Drawing.Point(65, 65);
            this.lbListaPeliculas.Name = "lbListaPeliculas";
            this.lbListaPeliculas.Size = new System.Drawing.Size(679, 316);
            this.lbListaPeliculas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de peliculas";
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbListaPeliculas);
            this.Name = "FormPeliculas";
            this.Text = "FormPeliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaPeliculas;
        private System.Windows.Forms.Label label1;
    }
}