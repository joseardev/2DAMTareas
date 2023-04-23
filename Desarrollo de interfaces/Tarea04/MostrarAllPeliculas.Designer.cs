namespace Tarea4
{
    partial class MostrarAllPeliculas
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
            this.lbTotalPeliculas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTotalPeliculas
            // 
            this.lbTotalPeliculas.FormattingEnabled = true;
            this.lbTotalPeliculas.ItemHeight = 15;
            this.lbTotalPeliculas.Location = new System.Drawing.Point(62, 35);
            this.lbTotalPeliculas.Name = "lbTotalPeliculas";
            this.lbTotalPeliculas.Size = new System.Drawing.Size(675, 334);
            this.lbTotalPeliculas.TabIndex = 0;
            // 
            // MostrarAllPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTotalPeliculas);
            this.Name = "MostrarAllPeliculas";
            this.Text = "Todas las peliculas";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbTotalPeliculas;
    }
}