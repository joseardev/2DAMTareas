namespace Tarea01AccesoDatos
{
    partial class Form1
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
            this.btEjercicio1 = new System.Windows.Forms.Button();
            this.btEjercicio2 = new System.Windows.Forms.Button();
            this.btEjercicio3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEjercicio1
            // 
            this.btEjercicio1.Location = new System.Drawing.Point(153, 12);
            this.btEjercicio1.Name = "btEjercicio1";
            this.btEjercicio1.Size = new System.Drawing.Size(462, 104);
            this.btEjercicio1.TabIndex = 0;
            this.btEjercicio1.Text = "Ejercicio1";
            this.btEjercicio1.UseVisualStyleBackColor = true;
            this.btEjercicio1.Click += new System.EventHandler(this.btEjercicio1_Click);
            // 
            // btEjercicio2
            // 
            this.btEjercicio2.Location = new System.Drawing.Point(153, 148);
            this.btEjercicio2.Name = "btEjercicio2";
            this.btEjercicio2.Size = new System.Drawing.Size(462, 103);
            this.btEjercicio2.TabIndex = 1;
            this.btEjercicio2.Text = "Ejercicio2";
            this.btEjercicio2.UseVisualStyleBackColor = true;
            this.btEjercicio2.Click += new System.EventHandler(this.btEjercicio2_Click);
            // 
            // btEjercicio3
            // 
            this.btEjercicio3.Location = new System.Drawing.Point(153, 286);
            this.btEjercicio3.Name = "btEjercicio3";
            this.btEjercicio3.Size = new System.Drawing.Size(462, 102);
            this.btEjercicio3.TabIndex = 2;
            this.btEjercicio3.Text = "Ejercicio3";
            this.btEjercicio3.UseVisualStyleBackColor = true;
            this.btEjercicio3.Click += new System.EventHandler(this.btEjercicio3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 449);
            this.Controls.Add(this.btEjercicio3);
            this.Controls.Add(this.btEjercicio2);
            this.Controls.Add(this.btEjercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btEjercicio1;
        private Button btEjercicio2;
        private Button btEjercicio3;
    }
}