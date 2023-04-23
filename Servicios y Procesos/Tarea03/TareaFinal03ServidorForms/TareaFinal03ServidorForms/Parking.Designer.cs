namespace TareaFinal03ServidorForms
{
    partial class Parking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLogMensajes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbListaAparcados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEstadoParking = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericPlazas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btAbrirParking = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlazas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbLogMensajes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbListaAparcados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEstadoParking);
            this.groupBox1.Location = new System.Drawing.Point(381, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Parking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Log Parking";
            // 
            // lbLogMensajes
            // 
            this.lbLogMensajes.FormattingEnabled = true;
            this.lbLogMensajes.ItemHeight = 15;
            this.lbLogMensajes.Location = new System.Drawing.Point(274, 46);
            this.lbLogMensajes.Name = "lbLogMensajes";
            this.lbLogMensajes.Size = new System.Drawing.Size(106, 184);
            this.lbLogMensajes.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coches Aparcados";
            // 
            // lbListaAparcados
            // 
            this.lbListaAparcados.FormattingEnabled = true;
            this.lbListaAparcados.ItemHeight = 15;
            this.lbListaAparcados.Location = new System.Drawing.Point(123, 46);
            this.lbListaAparcados.Name = "lbListaAparcados";
            this.lbListaAparcados.Size = new System.Drawing.Size(115, 184);
            this.lbListaAparcados.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estado Parking";
            // 
            // tbEstadoParking
            // 
            this.tbEstadoParking.Location = new System.Drawing.Point(9, 46);
            this.tbEstadoParking.Name = "tbEstadoParking";
            this.tbEstadoParking.Size = new System.Drawing.Size(100, 23);
            this.tbEstadoParking.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericPlazas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btAbrirParking);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 184);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // numericPlazas
            // 
            this.numericPlazas.Location = new System.Drawing.Point(177, 33);
            this.numericPlazas.Name = "numericPlazas";
            this.numericPlazas.Size = new System.Drawing.Size(41, 23);
            this.numericPlazas.TabIndex = 17;            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Aparcamiento Disponible";
            // 
            // btAbrirParking
            // 
            this.btAbrirParking.Location = new System.Drawing.Point(541, 35);
            this.btAbrirParking.Name = "btAbrirParking";
            this.btAbrirParking.Size = new System.Drawing.Size(165, 109);
            this.btAbrirParking.TabIndex = 14;
            this.btAbrirParking.Text = "Abrir parking";
            this.btAbrirParking.UseVisualStyleBackColor = true;
            this.btAbrirParking.Click += new System.EventHandler(this.btAbrirParking_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 236);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "aparcar otro cliente.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "En caso de tener ocupado el total de plazas avisa al cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "de que esta ocupado. Cuando una plaza quede libre puede";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "que pueden aparcar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "El número de aparcamientos disponibles seran los coches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Este programa Emula un parking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlazas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbEstadoParking;
        private Label label3;
        private ListBox lbLogMensajes;
        private Label label2;
        private ListBox lbListaAparcados;
        private GroupBox groupBox2;
        private Label label4;
        private Button btAbrirParking;
        private NumericUpDown numericPlazas;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}