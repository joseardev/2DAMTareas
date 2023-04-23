namespace Tarea03Pokemon
{
    partial class FormMenuPrincipal
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
            this.btEjercicio1 = new System.Windows.Forms.Button();
            this.btCentroPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEjercicio1
            // 
            this.btEjercicio1.Location = new System.Drawing.Point(78, 37);
            this.btEjercicio1.Name = "btEjercicio1";
            this.btEjercicio1.Size = new System.Drawing.Size(636, 142);
            this.btEjercicio1.TabIndex = 0;
            this.btEjercicio1.Text = "Ejercicio 1";
            this.btEjercicio1.UseVisualStyleBackColor = true;
            this.btEjercicio1.Click += new System.EventHandler(this.btEjercicio1_Click);
            // 
            // btCentroPokemon
            // 
            this.btCentroPokemon.Location = new System.Drawing.Point(78, 214);
            this.btCentroPokemon.Name = "btCentroPokemon";
            this.btCentroPokemon.Size = new System.Drawing.Size(636, 174);
            this.btCentroPokemon.TabIndex = 1;
            this.btCentroPokemon.Text = "Ejercicio 2 ";
            this.btCentroPokemon.UseVisualStyleBackColor = true;
            this.btCentroPokemon.Click += new System.EventHandler(this.btCentroPokemon_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCentroPokemon);
            this.Controls.Add(this.btEjercicio1);
            this.Name = "FormMenuPrincipal";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEjercicio1;
        private System.Windows.Forms.Button btCentroPokemon;
    }
}