namespace Tarea4
{
    partial class MainPeliculas
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
            this.lbListaPeliculas = new System.Windows.Forms.ListBox();
            this.btEditarPelicula = new System.Windows.Forms.Button();
            this.btAñadirPelicula = new System.Windows.Forms.Button();
            this.btMostrarPelicula = new System.Windows.Forms.Button();
            this.btMostrarLista = new System.Windows.Forms.Button();
            this.tbCodigoPelicula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbListaPeliculas
            // 
            this.lbListaPeliculas.FormattingEnabled = true;
            this.lbListaPeliculas.ItemHeight = 15;
            this.lbListaPeliculas.Location = new System.Drawing.Point(274, 32);
            this.lbListaPeliculas.Name = "lbListaPeliculas";
            this.lbListaPeliculas.Size = new System.Drawing.Size(641, 364);
            this.lbListaPeliculas.TabIndex = 0;
            // 
            // btEditarPelicula
            // 
            this.btEditarPelicula.Location = new System.Drawing.Point(12, 121);
            this.btEditarPelicula.Name = "btEditarPelicula";
            this.btEditarPelicula.Size = new System.Drawing.Size(241, 23);
            this.btEditarPelicula.TabIndex = 1;
            this.btEditarPelicula.Text = "Editar Pelicula";
            this.btEditarPelicula.UseVisualStyleBackColor = true;
            this.btEditarPelicula.Click += new System.EventHandler(this.btEditarPelicula_Click);
            // 
            // btAñadirPelicula
            // 
            this.btAñadirPelicula.Location = new System.Drawing.Point(12, 79);
            this.btAñadirPelicula.Name = "btAñadirPelicula";
            this.btAñadirPelicula.Size = new System.Drawing.Size(241, 23);
            this.btAñadirPelicula.TabIndex = 2;
            this.btAñadirPelicula.Text = "Añadir Pelicula";
            this.btAñadirPelicula.UseVisualStyleBackColor = true;
            this.btAñadirPelicula.Click += new System.EventHandler(this.btAñadirPelicula_Click);
            // 
            // btMostrarPelicula
            // 
            this.btMostrarPelicula.Location = new System.Drawing.Point(12, 32);
            this.btMostrarPelicula.Name = "btMostrarPelicula";
            this.btMostrarPelicula.Size = new System.Drawing.Size(135, 22);
            this.btMostrarPelicula.TabIndex = 3;
            this.btMostrarPelicula.Text = "Buscar Pelicula";
            this.btMostrarPelicula.UseVisualStyleBackColor = true;
            this.btMostrarPelicula.Click += new System.EventHandler(this.btMostrarPelicula_Click);
            // 
            // btMostrarLista
            // 
            this.btMostrarLista.Location = new System.Drawing.Point(12, 163);
            this.btMostrarLista.Name = "btMostrarLista";
            this.btMostrarLista.Size = new System.Drawing.Size(241, 23);
            this.btMostrarLista.TabIndex = 4;
            this.btMostrarLista.Text = "Mostrar Lista";
            this.btMostrarLista.UseVisualStyleBackColor = true;
            this.btMostrarLista.Click += new System.EventHandler(this.btMostrarLista_Click);
            // 
            // tbCodigoPelicula
            // 
            this.tbCodigoPelicula.Location = new System.Drawing.Point(153, 31);
            this.tbCodigoPelicula.Name = "tbCodigoPelicula";
            this.tbCodigoPelicula.Size = new System.Drawing.Size(100, 23);
            this.tbCodigoPelicula.TabIndex = 5;
            // 
            // MainPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.tbCodigoPelicula);
            this.Controls.Add(this.btMostrarLista);
            this.Controls.Add(this.btMostrarPelicula);
            this.Controls.Add(this.btAñadirPelicula);
            this.Controls.Add(this.btEditarPelicula);
            this.Controls.Add(this.lbListaPeliculas);
            this.Name = "MainPeliculas";
            this.Text = "VideoClub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbListaPeliculas;
        private Button btEditarPelicula;
        private Button btAñadirPelicula;
        private Button btMostrarPelicula;
        private Button btMostrarLista;
        private TextBox tbCodigoPelicula;
    }
}