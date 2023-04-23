namespace Tarea4Ejercicio2
{
    partial class FormModificarFutbolista
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
            this.tbCodigoFut = new System.Windows.Forms.TextBox();
            this.tbCodigoEquipo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPosicion = new System.Windows.Forms.TextBox();
            this.btModificarFutbolista = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCodigoFut
            // 
            this.tbCodigoFut.Location = new System.Drawing.Point(22, 28);
            this.tbCodigoFut.Name = "tbCodigoFut";
            this.tbCodigoFut.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoFut.TabIndex = 0;
            // 
            // tbCodigoEquipo
            // 
            this.tbCodigoEquipo.Location = new System.Drawing.Point(22, 108);
            this.tbCodigoEquipo.Name = "tbCodigoEquipo";
            this.tbCodigoEquipo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoEquipo.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(22, 67);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbPosicion
            // 
            this.tbPosicion.Location = new System.Drawing.Point(22, 147);
            this.tbPosicion.Name = "tbPosicion";
            this.tbPosicion.Size = new System.Drawing.Size(100, 20);
            this.tbPosicion.TabIndex = 3;
            // 
            // btModificarFutbolista
            // 
            this.btModificarFutbolista.Location = new System.Drawing.Point(22, 186);
            this.btModificarFutbolista.Name = "btModificarFutbolista";
            this.btModificarFutbolista.Size = new System.Drawing.Size(100, 35);
            this.btModificarFutbolista.TabIndex = 4;
            this.btModificarFutbolista.Text = "Modificar";
            this.btModificarFutbolista.UseVisualStyleBackColor = true;
            this.btModificarFutbolista.Click += new System.EventHandler(this.btModificarFutbolista_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Posicion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Codigo Equipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre Futbolista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Codigo Futbolista";
            // 
            // FormModificarFutbolista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btModificarFutbolista);
            this.Controls.Add(this.tbPosicion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigoEquipo);
            this.Controls.Add(this.tbCodigoFut);
            this.Name = "FormModificarFutbolista";
            this.Text = "FormModificarFutbolista";
            this.Load += new System.EventHandler(this.FormModificarFutbolista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoFut;
        private System.Windows.Forms.TextBox tbCodigoEquipo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPosicion;
        private System.Windows.Forms.Button btModificarFutbolista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}