namespace Tarea01AccesoDatos
{
    partial class Ejercicio2
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
            this.btSelectFicheroOrigen = new System.Windows.Forms.Button();
            this.btSelecionarCarpetaDestino = new System.Windows.Forms.Button();
            this.tbRutaFicheroOrigen = new System.Windows.Forms.TextBox();
            this.tbCarpetaDestino = new System.Windows.Forms.TextBox();
            this.btCopiaFichero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSelectFicheroOrigen
            // 
            this.btSelectFicheroOrigen.Location = new System.Drawing.Point(12, 12);
            this.btSelectFicheroOrigen.Name = "btSelectFicheroOrigen";
            this.btSelectFicheroOrigen.Size = new System.Drawing.Size(226, 63);
            this.btSelectFicheroOrigen.TabIndex = 0;
            this.btSelectFicheroOrigen.Text = "seleciona fichero origen";
            this.btSelectFicheroOrigen.UseVisualStyleBackColor = true;
            this.btSelectFicheroOrigen.Click += new System.EventHandler(this.btSelectFicheroOrigen_Click);
            // 
            // btSelecionarCarpetaDestino
            // 
            this.btSelecionarCarpetaDestino.Location = new System.Drawing.Point(12, 92);
            this.btSelecionarCarpetaDestino.Name = "btSelecionarCarpetaDestino";
            this.btSelecionarCarpetaDestino.Size = new System.Drawing.Size(226, 60);
            this.btSelecionarCarpetaDestino.TabIndex = 1;
            this.btSelecionarCarpetaDestino.Text = "Selecionar carpeta destino";
            this.btSelecionarCarpetaDestino.UseVisualStyleBackColor = true;
            this.btSelecionarCarpetaDestino.Click += new System.EventHandler(this.btSelecionarCarpetaDestino_Click);
            // 
            // tbRutaFicheroOrigen
            // 
            this.tbRutaFicheroOrigen.Location = new System.Drawing.Point(244, 33);
            this.tbRutaFicheroOrigen.Name = "tbRutaFicheroOrigen";
            this.tbRutaFicheroOrigen.ReadOnly = true;
            this.tbRutaFicheroOrigen.Size = new System.Drawing.Size(529, 23);
            this.tbRutaFicheroOrigen.TabIndex = 2;
            // 
            // tbCarpetaDestino
            // 
            this.tbCarpetaDestino.Location = new System.Drawing.Point(244, 112);
            this.tbCarpetaDestino.Name = "tbCarpetaDestino";
            this.tbCarpetaDestino.ReadOnly = true;
            this.tbCarpetaDestino.Size = new System.Drawing.Size(529, 23);
            this.tbCarpetaDestino.TabIndex = 3;
            // 
            // btCopiaFichero
            // 
            this.btCopiaFichero.Location = new System.Drawing.Point(12, 210);
            this.btCopiaFichero.Name = "btCopiaFichero";
            this.btCopiaFichero.Size = new System.Drawing.Size(226, 68);
            this.btCopiaFichero.TabIndex = 4;
            this.btCopiaFichero.Text = "copiar Fichero";
            this.btCopiaFichero.UseVisualStyleBackColor = true;
            this.btCopiaFichero.Click += new System.EventHandler(this.btCopiaFichero_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 358);
            this.Controls.Add(this.btCopiaFichero);
            this.Controls.Add(this.tbCarpetaDestino);
            this.Controls.Add(this.tbRutaFicheroOrigen);
            this.Controls.Add(this.btSelecionarCarpetaDestino);
            this.Controls.Add(this.btSelectFicheroOrigen);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSelectFicheroOrigen;
        private Button btSelecionarCarpetaDestino;
        private TextBox tbRutaFicheroOrigen;
        private TextBox tbCarpetaDestino;
        private Button btCopiaFichero;
    }
}