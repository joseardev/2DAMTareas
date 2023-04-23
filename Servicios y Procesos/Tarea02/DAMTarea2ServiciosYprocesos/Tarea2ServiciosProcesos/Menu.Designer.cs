namespace Tarea2ServiciosProcesos
{
    partial class Menu
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
            this.brCaballos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brCaballos
            // 
            this.brCaballos.Location = new System.Drawing.Point(209, 98);
            this.brCaballos.Name = "brCaballos";
            this.brCaballos.Size = new System.Drawing.Size(348, 225);
            this.brCaballos.TabIndex = 0;
            this.brCaballos.Text = "CARRERA \r\nCABALLOS";
            this.brCaballos.UseVisualStyleBackColor = true;
            this.brCaballos.Click += new System.EventHandler(this.brCaballos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brCaballos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button brCaballos;
    }
}