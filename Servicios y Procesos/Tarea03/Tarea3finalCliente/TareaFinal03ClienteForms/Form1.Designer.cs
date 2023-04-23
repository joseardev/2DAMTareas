namespace TareaFinal03ClienteForms
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
            this.lbLogMensajes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMensajeCliente = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.tbSalir = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbPrecioParking = new System.Windows.Forms.TextBox();
            this.btPagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLogMensajes
            // 
            this.lbLogMensajes.FormattingEnabled = true;
            this.lbLogMensajes.ItemHeight = 15;
            this.lbLogMensajes.Location = new System.Drawing.Point(256, 32);
            this.lbLogMensajes.Name = "lbLogMensajes";
            this.lbLogMensajes.Size = new System.Drawing.Size(207, 394);
            this.lbLogMensajes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log Aparcando";
            // 
            // tbMensajeCliente
            // 
            this.tbMensajeCliente.Location = new System.Drawing.Point(86, 32);
            this.tbMensajeCliente.Name = "tbMensajeCliente";
            this.tbMensajeCliente.Size = new System.Drawing.Size(100, 23);
            this.tbMensajeCliente.TabIndex = 9;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(5, 31);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 8;
            this.btEnviar.Text = "Aparcar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // tbSalir
            // 
            this.tbSalir.Location = new System.Drawing.Point(86, 60);
            this.tbSalir.Name = "tbSalir";
            this.tbSalir.Size = new System.Drawing.Size(100, 23);
            this.tbSalir.TabIndex = 11;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(5, 60);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tbPrecioParking
            // 
            this.tbPrecioParking.Location = new System.Drawing.Point(86, 89);
            this.tbPrecioParking.Name = "tbPrecioParking";
            this.tbPrecioParking.Size = new System.Drawing.Size(100, 23);
            this.tbPrecioParking.TabIndex = 13;
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(5, 89);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(75, 23);
            this.btPagar.TabIndex = 12;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente debe Aparcar -> Salir -> Pagar ->Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrecioParking);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.tbSalir);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.tbMensajeCliente);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogMensajes);
            this.Name = "Form1";
            this.Text = "cliente 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lbLogMensajes;
        private Label label1;
        private Label label2;
        private TextBox tbMensajeCliente;
        private Button btEnviar;
        private TextBox tbSalir;
        private Button btSalir;
        private TextBox tbPrecioParking;
        private Button btPagar;
        private Label label3;
    }
}