namespace Tarea4Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbFutbolistas = new System.Windows.Forms.ListBox();
            this.btBorrarEquipo = new System.Windows.Forms.Button();
            this.btBorrarFutbolista = new System.Windows.Forms.Button();
            this.tbCodigoEquipo = new System.Windows.Forms.TextBox();
            this.tbNombreEquipo = new System.Windows.Forms.TextBox();
            this.tbPaisEquipo = new System.Windows.Forms.TextBox();
            this.tbGolesEquipo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFutbolistas = new System.Windows.Forms.ComboBox();
            this.btBuscarEquipos = new System.Windows.Forms.Button();
            this.btModificarEquipos = new System.Windows.Forms.Button();
            this.lbEQuipos = new System.Windows.Forms.ListBox();
            this.btAddEquipo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.btBuscarFutbolistas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificarFutbolista = new System.Windows.Forms.Button();
            this.btAddFutbolista = new System.Windows.Forms.Button();
            this.tbPosicionFut = new System.Windows.Forms.TextBox();
            this.tbNombreFut = new System.Windows.Forms.TextBox();
            this.tbCodigoFut = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEquiposModificar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFutbolistas
            // 
            this.lbFutbolistas.FormattingEnabled = true;
            this.lbFutbolistas.Location = new System.Drawing.Point(209, 19);
            this.lbFutbolistas.Name = "lbFutbolistas";
            this.lbFutbolistas.Size = new System.Drawing.Size(153, 277);
            this.lbFutbolistas.TabIndex = 1;
            // 
            // btBorrarEquipo
            // 
            this.btBorrarEquipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBorrarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btBorrarEquipo.Image")));
            this.btBorrarEquipo.Location = new System.Drawing.Point(202, 296);
            this.btBorrarEquipo.Name = "btBorrarEquipo";
            this.btBorrarEquipo.Size = new System.Drawing.Size(42, 32);
            this.btBorrarEquipo.TabIndex = 2;
            this.btBorrarEquipo.UseVisualStyleBackColor = false;
            this.btBorrarEquipo.Click += new System.EventHandler(this.btBorrarEquipo_Click);
            // 
            // btBorrarFutbolista
            // 
            this.btBorrarFutbolista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBorrarFutbolista.Image = ((System.Drawing.Image)(resources.GetObject("btBorrarFutbolista.Image")));
            this.btBorrarFutbolista.Location = new System.Drawing.Point(209, 296);
            this.btBorrarFutbolista.Name = "btBorrarFutbolista";
            this.btBorrarFutbolista.Size = new System.Drawing.Size(43, 32);
            this.btBorrarFutbolista.TabIndex = 3;
            this.btBorrarFutbolista.UseVisualStyleBackColor = false;
            this.btBorrarFutbolista.Click += new System.EventHandler(this.btBorrarFutbolista_Click);
            // 
            // tbCodigoEquipo
            // 
            this.tbCodigoEquipo.Location = new System.Drawing.Point(17, 44);
            this.tbCodigoEquipo.Name = "tbCodigoEquipo";
            this.tbCodigoEquipo.Size = new System.Drawing.Size(129, 20);
            this.tbCodigoEquipo.TabIndex = 4;
            // 
            // tbNombreEquipo
            // 
            this.tbNombreEquipo.Location = new System.Drawing.Point(17, 83);
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.Size = new System.Drawing.Size(129, 20);
            this.tbNombreEquipo.TabIndex = 5;
            // 
            // tbPaisEquipo
            // 
            this.tbPaisEquipo.Location = new System.Drawing.Point(17, 122);
            this.tbPaisEquipo.Name = "tbPaisEquipo";
            this.tbPaisEquipo.Size = new System.Drawing.Size(129, 20);
            this.tbPaisEquipo.TabIndex = 6;
            // 
            // tbGolesEquipo
            // 
            this.tbGolesEquipo.Location = new System.Drawing.Point(17, 161);
            this.tbGolesEquipo.Name = "tbGolesEquipo";
            this.tbGolesEquipo.Size = new System.Drawing.Size(129, 20);
            this.tbGolesEquipo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFutbolistas);
            this.groupBox1.Controls.Add(this.btBuscarEquipos);
            this.groupBox1.Controls.Add(this.btModificarEquipos);
            this.groupBox1.Controls.Add(this.lbEQuipos);
            this.groupBox1.Controls.Add(this.btBorrarEquipo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 334);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Futbolista";
            // 
            // cbFutbolistas
            // 
            this.cbFutbolistas.FormattingEnabled = true;
            this.cbFutbolistas.Location = new System.Drawing.Point(25, 35);
            this.cbFutbolistas.Name = "cbFutbolistas";
            this.cbFutbolistas.Size = new System.Drawing.Size(121, 21);
            this.cbFutbolistas.TabIndex = 12;
            // 
            // btBuscarEquipos
            // 
            this.btBuscarEquipos.Location = new System.Drawing.Point(25, 62);
            this.btBuscarEquipos.Name = "btBuscarEquipos";
            this.btBuscarEquipos.Size = new System.Drawing.Size(121, 35);
            this.btBuscarEquipos.TabIndex = 11;
            this.btBuscarEquipos.Text = "Buscar Equipos";
            this.btBuscarEquipos.UseVisualStyleBackColor = true;
            this.btBuscarEquipos.Click += new System.EventHandler(this.btBuscarEquipos_Click);
            // 
            // btModificarEquipos
            // 
            this.btModificarEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btModificarEquipos.Image")));
            this.btModificarEquipos.Location = new System.Drawing.Point(313, 296);
            this.btModificarEquipos.Name = "btModificarEquipos";
            this.btModificarEquipos.Size = new System.Drawing.Size(42, 33);
            this.btModificarEquipos.TabIndex = 9;
            this.btModificarEquipos.UseVisualStyleBackColor = true;
            this.btModificarEquipos.Click += new System.EventHandler(this.btModificarEquipos_Click);
            // 
            // lbEQuipos
            // 
            this.lbEQuipos.FormattingEnabled = true;
            this.lbEQuipos.Location = new System.Drawing.Point(202, 19);
            this.lbEQuipos.Name = "lbEQuipos";
            this.lbEQuipos.Size = new System.Drawing.Size(153, 277);
            this.lbEQuipos.TabIndex = 1;
            // 
            // btAddEquipo
            // 
            this.btAddEquipo.Location = new System.Drawing.Point(246, 67);
            this.btAddEquipo.Name = "btAddEquipo";
            this.btAddEquipo.Size = new System.Drawing.Size(100, 59);
            this.btAddEquipo.TabIndex = 8;
            this.btAddEquipo.Text = "Añadir Equipo";
            this.btAddEquipo.UseVisualStyleBackColor = true;
            this.btAddEquipo.Click += new System.EventHandler(this.btAddEquipo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEquipos);
            this.groupBox2.Controls.Add(this.btBuscarFutbolistas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btModificarFutbolista);
            this.groupBox2.Controls.Add(this.lbFutbolistas);
            this.groupBox2.Controls.Add(this.btBorrarFutbolista);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 334);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Futbolistas";
            // 
            // cbEquipos
            // 
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(20, 35);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(121, 21);
            this.cbEquipos.TabIndex = 13;
            // 
            // btBuscarFutbolistas
            // 
            this.btBuscarFutbolistas.Location = new System.Drawing.Point(20, 62);
            this.btBuscarFutbolistas.Name = "btBuscarFutbolistas";
            this.btBuscarFutbolistas.Size = new System.Drawing.Size(121, 34);
            this.btBuscarFutbolistas.TabIndex = 12;
            this.btBuscarFutbolistas.Text = "Buscar Futbolistas";
            this.btBuscarFutbolistas.UseVisualStyleBackColor = true;
            this.btBuscarFutbolistas.Click += new System.EventHandler(this.btBuscarFutbolistas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Equipo";
            // 
            // btModificarFutbolista
            // 
            this.btModificarFutbolista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btModificarFutbolista.Image = ((System.Drawing.Image)(resources.GetObject("btModificarFutbolista.Image")));
            this.btModificarFutbolista.Location = new System.Drawing.Point(318, 296);
            this.btModificarFutbolista.Name = "btModificarFutbolista";
            this.btModificarFutbolista.Size = new System.Drawing.Size(44, 33);
            this.btModificarFutbolista.TabIndex = 9;
            this.btModificarFutbolista.UseVisualStyleBackColor = false;
            this.btModificarFutbolista.Click += new System.EventHandler(this.btModificarFutbolista_Click);
            // 
            // btAddFutbolista
            // 
            this.btAddFutbolista.Location = new System.Drawing.Point(263, 67);
            this.btAddFutbolista.Name = "btAddFutbolista";
            this.btAddFutbolista.Size = new System.Drawing.Size(99, 59);
            this.btAddFutbolista.TabIndex = 8;
            this.btAddFutbolista.Text = "Añadir Futbolista";
            this.btAddFutbolista.UseVisualStyleBackColor = true;
            this.btAddFutbolista.Click += new System.EventHandler(this.btAddFutbolista_Click);
            // 
            // tbPosicionFut
            // 
            this.tbPosicionFut.Location = new System.Drawing.Point(20, 161);
            this.tbPosicionFut.Name = "tbPosicionFut";
            this.tbPosicionFut.Size = new System.Drawing.Size(121, 20);
            this.tbPosicionFut.TabIndex = 7;
            // 
            // tbNombreFut
            // 
            this.tbNombreFut.Location = new System.Drawing.Point(20, 83);
            this.tbNombreFut.Name = "tbNombreFut";
            this.tbNombreFut.Size = new System.Drawing.Size(121, 20);
            this.tbNombreFut.TabIndex = 5;
            // 
            // tbCodigoFut
            // 
            this.tbCodigoFut.Location = new System.Drawing.Point(20, 44);
            this.tbCodigoFut.Name = "tbCodigoFut";
            this.tbCodigoFut.Size = new System.Drawing.Size(121, 20);
            this.tbCodigoFut.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbCodigoEquipo);
            this.groupBox3.Controls.Add(this.btAddEquipo);
            this.groupBox3.Controls.Add(this.tbNombreEquipo);
            this.groupBox3.Controls.Add(this.tbGolesEquipo);
            this.groupBox3.Controls.Add(this.tbPaisEquipo);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 198);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Añadir Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo Equipo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbEquiposModificar);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbCodigoFut);
            this.groupBox4.Controls.Add(this.btAddFutbolista);
            this.groupBox4.Controls.Add(this.tbNombreFut);
            this.groupBox4.Controls.Add(this.tbPosicionFut);
            this.groupBox4.Location = new System.Drawing.Point(398, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 198);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Añadir Futbolista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre Equipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Goles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo Futbolista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre Futbolista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Codigo Equipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Posicion";
            // 
            // cbEquiposModificar
            // 
            this.cbEquiposModificar.FormattingEnabled = true;
            this.cbEquiposModificar.Location = new System.Drawing.Point(20, 121);
            this.cbEquiposModificar.Name = "cbEquiposModificar";
            this.cbEquiposModificar.Size = new System.Drawing.Size(121, 21);
            this.cbEquiposModificar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbFutbolistas;
        private System.Windows.Forms.Button btBorrarEquipo;
        private System.Windows.Forms.Button btBorrarFutbolista;
        private System.Windows.Forms.TextBox tbCodigoEquipo;
        private System.Windows.Forms.TextBox tbNombreEquipo;
        private System.Windows.Forms.TextBox tbPaisEquipo;
        private System.Windows.Forms.TextBox tbGolesEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddEquipo;
        private System.Windows.Forms.ListBox lbEQuipos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddFutbolista;
        private System.Windows.Forms.TextBox tbPosicionFut;
        private System.Windows.Forms.TextBox tbNombreFut;
        private System.Windows.Forms.TextBox tbCodigoFut;
        private System.Windows.Forms.Button btModificarEquipos;
        private System.Windows.Forms.Button btModificarFutbolista;
        private System.Windows.Forms.Button btBuscarEquipos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btBuscarFutbolistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.ComboBox cbFutbolistas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEquiposModificar;
    }
}

