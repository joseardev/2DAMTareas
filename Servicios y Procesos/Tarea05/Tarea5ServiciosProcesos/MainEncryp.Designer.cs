namespace Tarea5ServiciosProcesos
{
    partial class MainEncryp
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
            this.btEncryp = new System.Windows.Forms.Button();
            this.btSelecionarFichero = new System.Windows.Forms.Button();
            this.tbFicheroSelecionado = new System.Windows.Forms.TextBox();
            this.tbFicheroEncryptado = new System.Windows.Forms.TextBox();
            this.btDesencriptarFichero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasswordDes = new System.Windows.Forms.TextBox();
            this.cbTypoDes = new System.Windows.Forms.ComboBox();
            this.btRutaDes = new System.Windows.Forms.Button();
            this.tbRutaDes = new System.Windows.Forms.TextBox();
            this.btSelecionarFicheroEncriptado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordEncriptado = new System.Windows.Forms.TextBox();
            this.btCarpetaDestinoDesencriptar = new System.Windows.Forms.Button();
            this.tbCarpetaDestino = new System.Windows.Forms.TextBox();
            this.cbTipoEncriptacion = new System.Windows.Forms.ComboBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btEncryptarText = new System.Windows.Forms.Button();
            this.tbTextoEncriptado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEncriptadoTexto = new System.Windows.Forms.ComboBox();
            this.tbTextoAEncriptar = new System.Windows.Forms.TextBox();
            this.tbClaveEncriptacionTexto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btDesencriptar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEncryp
            // 
            this.btEncryp.Location = new System.Drawing.Point(472, 163);
            this.btEncryp.Name = "btEncryp";
            this.btEncryp.Size = new System.Drawing.Size(172, 47);
            this.btEncryp.TabIndex = 0;
            this.btEncryp.Text = "Encriptar";
            this.btEncryp.UseVisualStyleBackColor = true;
            this.btEncryp.Click += new System.EventHandler(this.btEncryp_Click);
            // 
            // btSelecionarFichero
            // 
            this.btSelecionarFichero.Location = new System.Drawing.Point(472, 22);
            this.btSelecionarFichero.Name = "btSelecionarFichero";
            this.btSelecionarFichero.Size = new System.Drawing.Size(172, 23);
            this.btSelecionarFichero.TabIndex = 1;
            this.btSelecionarFichero.Text = "Seleccionar Fichero";
            this.btSelecionarFichero.UseVisualStyleBackColor = true;
            this.btSelecionarFichero.Click += new System.EventHandler(this.btSelecionarFichero_Click);
            // 
            // tbFicheroSelecionado
            // 
            this.tbFicheroSelecionado.Location = new System.Drawing.Point(18, 22);
            this.tbFicheroSelecionado.Name = "tbFicheroSelecionado";
            this.tbFicheroSelecionado.Size = new System.Drawing.Size(448, 23);
            this.tbFicheroSelecionado.TabIndex = 2;
            // 
            // tbFicheroEncryptado
            // 
            this.tbFicheroEncryptado.Location = new System.Drawing.Point(18, 22);
            this.tbFicheroEncryptado.Name = "tbFicheroEncryptado";
            this.tbFicheroEncryptado.Size = new System.Drawing.Size(448, 23);
            this.tbFicheroEncryptado.TabIndex = 3;
            // 
            // btDesencriptarFichero
            // 
            this.btDesencriptarFichero.Location = new System.Drawing.Point(472, 173);
            this.btDesencriptarFichero.Name = "btDesencriptarFichero";
            this.btDesencriptarFichero.Size = new System.Drawing.Size(172, 47);
            this.btDesencriptarFichero.TabIndex = 4;
            this.btDesencriptarFichero.Text = "Desencriptar Fichero";
            this.btDesencriptarFichero.UseVisualStyleBackColor = true;
            this.btDesencriptarFichero.Click += new System.EventHandler(this.btDesencriptarFichero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPasswordDes);
            this.groupBox1.Controls.Add(this.cbTypoDes);
            this.groupBox1.Controls.Add(this.btRutaDes);
            this.groupBox1.Controls.Add(this.tbRutaDes);
            this.groupBox1.Controls.Add(this.btSelecionarFicheroEncriptado);
            this.groupBox1.Controls.Add(this.tbFicheroEncryptado);
            this.groupBox1.Controls.Add(this.btDesencriptarFichero);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 228);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desencriptar Ficheros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña de encriptado";
            // 
            // tbPasswordDes
            // 
            this.tbPasswordDes.Location = new System.Drawing.Point(167, 105);
            this.tbPasswordDes.Name = "tbPasswordDes";
            this.tbPasswordDes.Size = new System.Drawing.Size(299, 23);
            this.tbPasswordDes.TabIndex = 9;
            // 
            // cbTypoDes
            // 
            this.cbTypoDes.FormattingEnabled = true;
            this.cbTypoDes.Items.AddRange(new object[] {
            "aes-128-cbc    ",
            "aes-128-ecb    ",
            "aes-192-cbc",
            "aes-192-ecb",
            "aes-256-cbc",
            "aes-256-ecb",
            "base64",
            "bf",
            "bf-cbc",
            "bf-cfb",
            "bf-ecb",
            "bf-ofb",
            "cast",
            "cast-cbc",
            "cast5-cbc",
            "cast5-cfb",
            "cast5-ecb",
            "cast5-ofb",
            "des",
            "des-cbc",
            "des-cfb",
            "des-ecb",
            "des-ede",
            "des-ede-cbc",
            "des-ede-cfb",
            "des-ede-ofb",
            "des-ede3",
            "des-ede3-cbc",
            "des-ede3-cfb",
            "des-ede3-ofb",
            "des-ofb",
            "des3",
            "desx",
            "idea ",
            "idea-cbc",
            "idea-cfb",
            "idea-ecb",
            "idea-ofb ",
            "rc2",
            "rc2-40-cbc",
            "rc2-64-cbc",
            "rc2-cbc",
            "rc2-cfb",
            "rc2-ecb",
            "rc2-ofb",
            "rc4",
            "rc4-40"});
            this.cbTypoDes.Location = new System.Drawing.Point(167, 144);
            this.cbTypoDes.Name = "cbTypoDes";
            this.cbTypoDes.Size = new System.Drawing.Size(299, 23);
            this.cbTypoDes.TabIndex = 8;
            // 
            // btRutaDes
            // 
            this.btRutaDes.Location = new System.Drawing.Point(472, 62);
            this.btRutaDes.Name = "btRutaDes";
            this.btRutaDes.Size = new System.Drawing.Size(172, 23);
            this.btRutaDes.TabIndex = 7;
            this.btRutaDes.Text = "Carpeta Destino";
            this.btRutaDes.UseVisualStyleBackColor = true;
            this.btRutaDes.Click += new System.EventHandler(this.btRutaDes_Click);
            // 
            // tbRutaDes
            // 
            this.tbRutaDes.Location = new System.Drawing.Point(18, 61);
            this.tbRutaDes.Name = "tbRutaDes";
            this.tbRutaDes.Size = new System.Drawing.Size(448, 23);
            this.tbRutaDes.TabIndex = 6;
            // 
            // btSelecionarFicheroEncriptado
            // 
            this.btSelecionarFicheroEncriptado.Location = new System.Drawing.Point(472, 22);
            this.btSelecionarFicheroEncriptado.Name = "btSelecionarFicheroEncriptado";
            this.btSelecionarFicheroEncriptado.Size = new System.Drawing.Size(172, 23);
            this.btSelecionarFicheroEncriptado.TabIndex = 5;
            this.btSelecionarFicheroEncriptado.Text = "Seleccionar Fichero";
            this.btSelecionarFicheroEncriptado.UseVisualStyleBackColor = true;
            this.btSelecionarFicheroEncriptado.Click += new System.EventHandler(this.btSelecionarFicheroEncriptado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPasswordEncriptado);
            this.groupBox2.Controls.Add(this.btCarpetaDestinoDesencriptar);
            this.groupBox2.Controls.Add(this.tbCarpetaDestino);
            this.groupBox2.Controls.Add(this.cbTipoEncriptacion);
            this.groupBox2.Controls.Add(this.tbFicheroSelecionado);
            this.groupBox2.Controls.Add(this.btEncryp);
            this.groupBox2.Controls.Add(this.btSelecionarFichero);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encriptar Ficheros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de encriptación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña de encriptado";
            // 
            // tbPasswordEncriptado
            // 
            this.tbPasswordEncriptado.Location = new System.Drawing.Point(167, 93);
            this.tbPasswordEncriptado.Name = "tbPasswordEncriptado";
            this.tbPasswordEncriptado.Size = new System.Drawing.Size(299, 23);
            this.tbPasswordEncriptado.TabIndex = 8;
            // 
            // btCarpetaDestinoDesencriptar
            // 
            this.btCarpetaDestinoDesencriptar.Location = new System.Drawing.Point(472, 61);
            this.btCarpetaDestinoDesencriptar.Name = "btCarpetaDestinoDesencriptar";
            this.btCarpetaDestinoDesencriptar.Size = new System.Drawing.Size(172, 23);
            this.btCarpetaDestinoDesencriptar.TabIndex = 7;
            this.btCarpetaDestinoDesencriptar.Text = "Carpeta Destino";
            this.btCarpetaDestinoDesencriptar.UseVisualStyleBackColor = true;
            this.btCarpetaDestinoDesencriptar.Click += new System.EventHandler(this.btCarpetaDestinoDesencriptar_Click);
            // 
            // tbCarpetaDestino
            // 
            this.tbCarpetaDestino.Location = new System.Drawing.Point(18, 61);
            this.tbCarpetaDestino.Name = "tbCarpetaDestino";
            this.tbCarpetaDestino.Size = new System.Drawing.Size(448, 23);
            this.tbCarpetaDestino.TabIndex = 6;
            // 
            // cbTipoEncriptacion
            // 
            this.cbTipoEncriptacion.FormattingEnabled = true;
            this.cbTipoEncriptacion.Items.AddRange(new object[] {
            "aes-128-cbc    ",
            "aes-128-ecb    ",
            "aes-192-cbc",
            "aes-192-ecb",
            "aes-256-cbc",
            "aes-256-ecb",
            "base64",
            "bf",
            "bf-cbc",
            "bf-cfb",
            "bf-ecb",
            "bf-ofb",
            "cast",
            "cast-cbc",
            "cast5-cbc",
            "cast5-cfb",
            "cast5-ecb",
            "cast5-ofb",
            "des",
            "des-cbc",
            "des-cfb",
            "des-ecb",
            "des-ede",
            "des-ede-cbc",
            "des-ede-cfb",
            "des-ede-ofb",
            "des-ede3",
            "des-ede3-cbc",
            "des-ede3-cfb",
            "des-ede3-ofb",
            "des-ofb",
            "des3",
            "desx",
            "idea ",
            "idea-cbc",
            "idea-cfb",
            "idea-ecb",
            "idea-ofb ",
            "rc2",
            "rc2-40-cbc",
            "rc2-64-cbc",
            "rc2-cbc",
            "rc2-cfb",
            "rc2-ecb",
            "rc2-ofb",
            "rc4",
            "rc4-40"});
            this.cbTipoEncriptacion.Location = new System.Drawing.Point(167, 130);
            this.cbTipoEncriptacion.Name = "cbTipoEncriptacion";
            this.cbTipoEncriptacion.Size = new System.Drawing.Size(299, 23);
            this.cbTipoEncriptacion.TabIndex = 5;
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.SystemColors.Info;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(12, 468);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(1100, 154);
            this.lbLog.TabIndex = 6;
            // 
            // btEncryptarText
            // 
            this.btEncryptarText.Location = new System.Drawing.Point(271, 133);
            this.btEncryptarText.Name = "btEncryptarText";
            this.btEncryptarText.Size = new System.Drawing.Size(121, 23);
            this.btEncryptarText.TabIndex = 7;
            this.btEncryptarText.Text = "Encriptar";
            this.btEncryptarText.UseVisualStyleBackColor = true;
            this.btEncryptarText.Click += new System.EventHandler(this.btEncryptarText_Click);
            // 
            // tbTextoEncriptado
            // 
            this.tbTextoEncriptado.Location = new System.Drawing.Point(6, 222);
            this.tbTextoEncriptado.Name = "tbTextoEncriptado";
            this.tbTextoEncriptado.Size = new System.Drawing.Size(421, 23);
            this.tbTextoEncriptado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de encriptación";
            // 
            // cbEncriptadoTexto
            // 
            this.cbEncriptadoTexto.FormattingEnabled = true;
            this.cbEncriptadoTexto.Items.AddRange(new object[] {
            "aes-128-cbc    ",
            "aes-128-ecb    ",
            "aes-192-cbc",
            "aes-192-ecb",
            "aes-256-cbc",
            "aes-256-ecb",
            "base64",
            "bf",
            "bf-cbc",
            "bf-cfb",
            "bf-ecb",
            "bf-ofb",
            "cast",
            "cast-cbc",
            "cast5-cbc",
            "cast5-cfb",
            "cast5-ecb",
            "cast5-ofb",
            "des",
            "des-cbc",
            "des-cfb",
            "des-ecb",
            "des-ede",
            "des-ede-cbc",
            "des-ede-cfb",
            "des-ede-ofb",
            "des-ede3",
            "des-ede3-cbc",
            "des-ede3-cfb",
            "des-ede3-ofb",
            "des-ofb",
            "des3",
            "desx",
            "idea ",
            "idea-cbc",
            "idea-cfb",
            "idea-ecb",
            "idea-ofb ",
            "rc2",
            "rc2-40-cbc",
            "rc2-64-cbc",
            "rc2-cbc",
            "rc2-cfb",
            "rc2-ecb",
            "rc2-ofb",
            "rc4",
            "rc4-40"});
            this.cbEncriptadoTexto.Location = new System.Drawing.Point(121, 93);
            this.cbEncriptadoTexto.Name = "cbEncriptadoTexto";
            this.cbEncriptadoTexto.Size = new System.Drawing.Size(271, 23);
            this.cbEncriptadoTexto.TabIndex = 11;
            // 
            // tbTextoAEncriptar
            // 
            this.tbTextoAEncriptar.Location = new System.Drawing.Point(121, 61);
            this.tbTextoAEncriptar.Name = "tbTextoAEncriptar";
            this.tbTextoAEncriptar.Size = new System.Drawing.Size(271, 23);
            this.tbTextoAEncriptar.TabIndex = 13;
            // 
            // tbClaveEncriptacionTexto
            // 
            this.tbClaveEncriptacionTexto.Location = new System.Drawing.Point(121, 22);
            this.tbClaveEncriptacionTexto.Name = "tbClaveEncriptacionTexto";
            this.tbClaveEncriptacionTexto.Size = new System.Drawing.Size(271, 23);
            this.tbClaveEncriptacionTexto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Texto a Encriptar";
            // 
            // btDesencriptar
            // 
            this.btDesencriptar.Location = new System.Drawing.Point(121, 133);
            this.btDesencriptar.Name = "btDesencriptar";
            this.btDesencriptar.Size = new System.Drawing.Size(117, 23);
            this.btDesencriptar.TabIndex = 17;
            this.btDesencriptar.Text = "Desencriptar";
            this.btDesencriptar.UseVisualStyleBackColor = true;
            this.btDesencriptar.Click += new System.EventHandler(this.btDesencriptar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btDesencriptar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbTextoEncriptado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btEncryptarText);
            this.groupBox3.Controls.Add(this.tbClaveEncriptacionTexto);
            this.groupBox3.Controls.Add(this.tbTextoAEncriptar);
            this.groupBox3.Controls.Add(this.cbEncriptadoTexto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(670, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 450);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encriptar Cadena de Texto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Resultado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tipo de encriptación";
            // 
            // MainEncryp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainEncryp";
            this.Text = "Crypto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btEncryp;
        private Button btSelecionarFichero;
        private TextBox tbFicheroSelecionado;
        private TextBox tbFicheroEncryptado;
        private Button btDesencriptarFichero;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbTipoEncriptacion;
        private Button btCarpetaDestinoDesencriptar;
        private TextBox tbCarpetaDestino;
        private Button btSelecionarFicheroEncriptado;
        private Button btRutaDes;
        private TextBox tbRutaDes;
        private ComboBox cbTypoDes;
        private ListBox lbLog;
        private Label label2;
        private TextBox tbPasswordDes;
        private Label label3;
        private Label label1;
        private TextBox tbPasswordEncriptado;
        private Button btEncryptarText;
        private TextBox tbTextoEncriptado;
        private Label label4;
        private ComboBox cbEncriptadoTexto;
        private TextBox tbTextoAEncriptar;
        private TextBox tbClaveEncriptacionTexto;
        private Label label5;
        private Label label6;
        private Button btDesencriptar;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
    }
}