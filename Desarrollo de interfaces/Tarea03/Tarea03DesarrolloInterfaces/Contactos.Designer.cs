namespace Tarea03DesarrolloInterfaces
{
    partial class Contactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contactos));
            this.lbContactos = new System.Windows.Forms.ListBox();
            this.btBorrarContacto = new System.Windows.Forms.Button();
            this.btModificarContacto = new System.Windows.Forms.Button();
            this.btAddContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContactos
            // 
            this.lbContactos.FormattingEnabled = true;
            this.lbContactos.ItemHeight = 15;
            this.lbContactos.Location = new System.Drawing.Point(12, 12);
            this.lbContactos.Name = "lbContactos";
            this.lbContactos.Size = new System.Drawing.Size(224, 274);
            this.lbContactos.TabIndex = 20;
            // 
            // btBorrarContacto
            // 
            this.btBorrarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btBorrarContacto.Image")));
            this.btBorrarContacto.Location = new System.Drawing.Point(98, 292);
            this.btBorrarContacto.Name = "btBorrarContacto";
            this.btBorrarContacto.Size = new System.Drawing.Size(49, 45);
            this.btBorrarContacto.TabIndex = 21;
            this.btBorrarContacto.UseVisualStyleBackColor = true;
            this.btBorrarContacto.Click += new System.EventHandler(this.btBorrarContacto_Click_1);
            // 
            // btModificarContacto
            // 
            this.btModificarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btModificarContacto.Image")));
            this.btModificarContacto.Location = new System.Drawing.Point(187, 292);
            this.btModificarContacto.Name = "btModificarContacto";
            this.btModificarContacto.Size = new System.Drawing.Size(49, 45);
            this.btModificarContacto.TabIndex = 22;
            this.btModificarContacto.UseVisualStyleBackColor = true;
            this.btModificarContacto.Click += new System.EventHandler(this.btModificarContacto_Click);
            // 
            // btAddContacto
            // 
            this.btAddContacto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddContacto.BackgroundImage")));
            this.btAddContacto.Location = new System.Drawing.Point(12, 292);
            this.btAddContacto.Name = "btAddContacto";
            this.btAddContacto.Size = new System.Drawing.Size(46, 45);
            this.btAddContacto.TabIndex = 23;
            this.btAddContacto.UseVisualStyleBackColor = true;
            this.btAddContacto.Click += new System.EventHandler(this.btAddContacto_Click);
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 370);
            this.Controls.Add(this.btAddContacto);
            this.Controls.Add(this.btModificarContacto);
            this.Controls.Add(this.btBorrarContacto);
            this.Controls.Add(this.lbContactos);
            this.Name = "Contactos";
            this.Text = "Fomulario Contactos";
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lbContactos;
        private Button btBorrarContacto;
        private Button btModificarContacto;
        private Button btAddContacto;
    }
}