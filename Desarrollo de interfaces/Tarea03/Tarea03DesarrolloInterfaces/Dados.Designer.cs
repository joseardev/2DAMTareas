namespace WinFormsApp1
{
    partial class Dados
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btTirarDado = new System.Windows.Forms.Button();
            this.btResultados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btTirarDado
            // 
            this.btTirarDado.Location = new System.Drawing.Point(152, 253);
            this.btTirarDado.Name = "btTirarDado";
            this.btTirarDado.Size = new System.Drawing.Size(75, 23);
            this.btTirarDado.TabIndex = 1;
            this.btTirarDado.Text = "TIRAR";
            this.btTirarDado.UseVisualStyleBackColor = true;
            this.btTirarDado.Click += new System.EventHandler(this.btTirarDado_Click);
            // 
            // btResultados
            // 
            this.btResultados.Location = new System.Drawing.Point(12, 253);
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(103, 23);
            this.btResultados.TabIndex = 2;
            this.btResultados.Text = "RESULTADOS";
            this.btResultados.UseVisualStyleBackColor = true;
            this.btResultados.Click += new System.EventHandler(this.btResultados_Click);
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 321);
            this.Controls.Add(this.btResultados);
            this.Controls.Add(this.btTirarDado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dados";
            this.Text = "Formulario Dados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btTirarDado;
        private Button btResultados;
    }
}