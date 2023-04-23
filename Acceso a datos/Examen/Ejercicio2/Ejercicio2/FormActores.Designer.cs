namespace Ejercicio2
{
    partial class FormActores
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
            this.lbTodosActores = new System.Windows.Forms.ListBox();
            this.tbNombreActor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCrearActor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTodosActores
            // 
            this.lbTodosActores.FormattingEnabled = true;
            this.lbTodosActores.Location = new System.Drawing.Point(488, 51);
            this.lbTodosActores.Name = "lbTodosActores";
            this.lbTodosActores.Size = new System.Drawing.Size(436, 329);
            this.lbTodosActores.TabIndex = 0;
            // 
            // tbNombreActor
            // 
            this.tbNombreActor.Location = new System.Drawing.Point(82, 51);
            this.tbNombreActor.Name = "tbNombreActor";
            this.tbNombreActor.Size = new System.Drawing.Size(100, 20);
            this.tbNombreActor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Actor";
            // 
            // btCrearActor
            // 
            this.btCrearActor.Location = new System.Drawing.Point(82, 92);
            this.btCrearActor.Name = "btCrearActor";
            this.btCrearActor.Size = new System.Drawing.Size(100, 23);
            this.btCrearActor.TabIndex = 3;
            this.btCrearActor.Text = "Crear Actor";
            this.btCrearActor.UseVisualStyleBackColor = true;
            this.btCrearActor.Click += new System.EventHandler(this.btCrearActor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista Actores";
            // 
            // FormActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCrearActor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreActor);
            this.Controls.Add(this.lbTodosActores);
            this.Name = "FormActores";
            this.Text = "FormActores";
            this.Load += new System.EventHandler(this.FormActores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTodosActores;
        private System.Windows.Forms.TextBox tbNombreActor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCrearActor;
        private System.Windows.Forms.Label label2;
    }
}