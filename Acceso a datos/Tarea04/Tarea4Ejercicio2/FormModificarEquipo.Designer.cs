namespace Tarea4Ejercicio2
{
    partial class FormModificarEquipo
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
            this.tbCodigoEquipo = new System.Windows.Forms.TextBox();
            this.tbNombreEquipo = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbGoles = new System.Windows.Forms.TextBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCodigoEquipo
            // 
            this.tbCodigoEquipo.Location = new System.Drawing.Point(23, 38);
            this.tbCodigoEquipo.Name = "tbCodigoEquipo";
            this.tbCodigoEquipo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoEquipo.TabIndex = 0;
            // 
            // tbNombreEquipo
            // 
            this.tbNombreEquipo.Location = new System.Drawing.Point(23, 77);
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.Size = new System.Drawing.Size(100, 20);
            this.tbNombreEquipo.TabIndex = 1;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(23, 118);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 20);
            this.tbPais.TabIndex = 2;
            // 
            // tbGoles
            // 
            this.tbGoles.Location = new System.Drawing.Point(23, 154);
            this.tbGoles.Name = "tbGoles";
            this.tbGoles.Size = new System.Drawing.Size(100, 20);
            this.tbGoles.TabIndex = 3;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(23, 195);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 40);
            this.btModificar.TabIndex = 4;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Goles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo Equipo";
            // 
            // FormModificarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.tbGoles);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbNombreEquipo);
            this.Controls.Add(this.tbCodigoEquipo);
            this.Name = "FormModificarEquipo";
            this.Text = "FormModificarEquipo";
            this.Load += new System.EventHandler(this.FormModificarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoEquipo;
        private System.Windows.Forms.TextBox tbNombreEquipo;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbGoles;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}