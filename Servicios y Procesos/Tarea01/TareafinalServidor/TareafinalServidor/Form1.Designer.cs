namespace TareafinalServidor
{
    partial class Servidor
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lbRecibidos = new System.Windows.Forms.ListBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusServer = new System.Windows.Forms.TextBox();
            this.btActivar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btActivaServidorAsync = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(13, 158);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(127, 23);
            this.txtMensaje.TabIndex = 2;
            // 
            // lbRecibidos
            // 
            this.lbRecibidos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbRecibidos.FormattingEnabled = true;
            this.lbRecibidos.ItemHeight = 15;
            this.lbRecibidos.Location = new System.Drawing.Point(13, 37);
            this.lbRecibidos.Margin = new System.Windows.Forms.Padding(2);
            this.lbRecibidos.Name = "lbRecibidos";
            this.lbRecibidos.Size = new System.Drawing.Size(127, 79);
            this.lbRecibidos.TabIndex = 4;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(164, 158);
            this.btEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(157, 23);
            this.btEnviar.TabIndex = 5;
            this.btEnviar.Text = "Enviar Mensaje";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStatusServer);
            this.groupBox1.Controls.Add(this.btActivar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(417, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estado servidor remoto";
            // 
            // txtStatusServer
            // 
            this.txtStatusServer.Location = new System.Drawing.Point(143, 22);
            this.txtStatusServer.Name = "txtStatusServer";
            this.txtStatusServer.Size = new System.Drawing.Size(229, 23);
            this.txtStatusServer.TabIndex = 7;
            // 
            // btActivar
            // 
            this.btActivar.Location = new System.Drawing.Point(143, 65);
            this.btActivar.Margin = new System.Windows.Forms.Padding(2);
            this.btActivar.Name = "btActivar";
            this.btActivar.Size = new System.Drawing.Size(229, 22);
            this.btActivar.TabIndex = 6;
            this.btActivar.Text = "Activar Servicio";
            this.btActivar.UseVisualStyleBackColor = true;
            this.btActivar.Click += new System.EventHandler(this.btActivar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbRecibidos);
            this.groupBox2.Controls.Add(this.txtMensaje);
            this.groupBox2.Controls.Add(this.btEnviar);
            this.groupBox2.Location = new System.Drawing.Point(-1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 217);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensajes Recibidos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.btActivaServidorAsync);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(417, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 224);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Async";
            // 
            // btActivaServidorAsync
            // 
            this.btActivaServidorAsync.Location = new System.Drawing.Point(143, 62);
            this.btActivaServidorAsync.Name = "btActivaServidorAsync";
            this.btActivaServidorAsync.Size = new System.Drawing.Size(229, 23);
            this.btActivaServidorAsync.TabIndex = 0;
            this.btActivaServidorAsync.Text = "Activar servidor asincrono";
            this.btActivaServidorAsync.UseVisualStyleBackColor = true;
            this.btActivaServidorAsync.Click += new System.EventHandler(this.btActivaServidorAsync_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server => Versión de comunicacion unidireccional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(13, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Info Aplicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "las dos versiones funcionan como la mimo textbox de envio.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Asincrono => Versión bidireccional ";
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Servidor";
            this.Text = "SERVIDOR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtMensaje;
        private ListBox lbRecibidos;
        private Button btEnviar;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtStatusServer;
        private Button btActivar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btActivaServidorAsync;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label2;
        private Label label6;
    }
}