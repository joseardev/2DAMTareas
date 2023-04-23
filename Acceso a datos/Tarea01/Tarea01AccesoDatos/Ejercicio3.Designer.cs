namespace Tarea01AccesoDatos
{
    partial class Ejercicio3
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
            this.btCargarFichero = new System.Windows.Forms.Button();
            this.tbDirectorioOrigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogRevisarCarpetas = new System.Windows.Forms.ListBox();
            this.btGeneraRutas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCargarFichero
            // 
            this.btCargarFichero.Location = new System.Drawing.Point(488, 21);
            this.btCargarFichero.Name = "btCargarFichero";
            this.btCargarFichero.Size = new System.Drawing.Size(165, 50);
            this.btCargarFichero.TabIndex = 0;
            this.btCargarFichero.Text = "Seleccionar Fichero De Datos";
            this.btCargarFichero.UseVisualStyleBackColor = true;
            this.btCargarFichero.Click += new System.EventHandler(this.btCargarFichero_Click);
            // 
            // tbDirectorioOrigen
            // 
            this.tbDirectorioOrigen.Enabled = false;
            this.tbDirectorioOrigen.Location = new System.Drawing.Point(22, 36);
            this.tbDirectorioOrigen.Name = "tbDirectorioOrigen";
            this.tbDirectorioOrigen.ShortcutsEnabled = false;
            this.tbDirectorioOrigen.Size = new System.Drawing.Size(424, 23);
            this.tbDirectorioOrigen.TabIndex = 1;
            this.tbDirectorioOrigen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directorio:";
            // 
            // lbLogRevisarCarpetas
            // 
            this.lbLogRevisarCarpetas.FormattingEnabled = true;
            this.lbLogRevisarCarpetas.ItemHeight = 15;
            this.lbLogRevisarCarpetas.Location = new System.Drawing.Point(22, 185);
            this.lbLogRevisarCarpetas.Name = "lbLogRevisarCarpetas";
            this.lbLogRevisarCarpetas.Size = new System.Drawing.Size(739, 199);
            this.lbLogRevisarCarpetas.TabIndex = 8;
            // 
            // btGeneraRutas
            // 
            this.btGeneraRutas.Location = new System.Drawing.Point(488, 94);
            this.btGeneraRutas.Name = "btGeneraRutas";
            this.btGeneraRutas.Size = new System.Drawing.Size(165, 49);
            this.btGeneraRutas.TabIndex = 9;
            this.btGeneraRutas.Text = "Generar rutas/Ficheros";
            this.btGeneraRutas.UseVisualStyleBackColor = true;
            this.btGeneraRutas.Click += new System.EventHandler(this.btGeneraRutas_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 412);
            this.Controls.Add(this.btGeneraRutas);
            this.Controls.Add(this.lbLogRevisarCarpetas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirectorioOrigen);
            this.Controls.Add(this.btCargarFichero);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lbLogRevisarCarpetas;
        private TextBox tbDirectorioOrigen;
        private Button btCargarFichero;
        private Button btGeneraRutas;
    }
}