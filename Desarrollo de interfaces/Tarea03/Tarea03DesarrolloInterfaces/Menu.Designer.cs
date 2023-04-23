namespace Tarea03DesarrolloInterfaces
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
            this.btContactos = new System.Windows.Forms.Button();
            this.btDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btContactos
            // 
            this.btContactos.Location = new System.Drawing.Point(244, 45);
            this.btContactos.Name = "btContactos";
            this.btContactos.Size = new System.Drawing.Size(286, 141);
            this.btContactos.TabIndex = 0;
            this.btContactos.Text = "Contactos";
            this.btContactos.UseVisualStyleBackColor = true;
            this.btContactos.Click += new System.EventHandler(this.btContactos_Click);
            // 
            // btDados
            // 
            this.btDados.Location = new System.Drawing.Point(244, 226);
            this.btDados.Name = "btDados";
            this.btDados.Size = new System.Drawing.Size(286, 139);
            this.btDados.TabIndex = 1;
            this.btDados.Text = "Dados";
            this.btDados.UseVisualStyleBackColor = true;
            this.btDados.Click += new System.EventHandler(this.btDados_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDados);
            this.Controls.Add(this.btContactos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btContactos;
        private Button btDados;
    }
}