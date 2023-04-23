namespace Examen
{
    partial class FormAddInstituto
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
            this.tbNombreInstituto = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddInstituto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombreInstituto
            // 
            this.tbNombreInstituto.Location = new System.Drawing.Point(101, 29);
            this.tbNombreInstituto.Name = "tbNombreInstituto";
            this.tbNombreInstituto.Size = new System.Drawing.Size(100, 23);
            this.tbNombreInstituto.TabIndex = 0;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(101, 58);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 23);
            this.tbDireccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // btAddInstituto
            // 
            this.btAddInstituto.Location = new System.Drawing.Point(101, 113);
            this.btAddInstituto.Name = "btAddInstituto";
            this.btAddInstituto.Size = new System.Drawing.Size(75, 23);
            this.btAddInstituto.TabIndex = 5;
            this.btAddInstituto.Text = "Añadir Instituto";
            this.btAddInstituto.UseVisualStyleBackColor = true;
            this.btAddInstituto.Click += new System.EventHandler(this.btAddInstituto_Click);
            // 
            // FormAddInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAddInstituto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombreInstituto);
            this.Name = "FormAddInstituto";
            this.Text = "FormAddInstituto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNombreInstituto;
        private TextBox tbDireccion;
        private Label label1;
        private Label label2;
        private Button btAddInstituto;
    }
}