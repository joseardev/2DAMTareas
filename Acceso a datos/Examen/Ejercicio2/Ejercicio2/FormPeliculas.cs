using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPeliculas : Form
    {
        Database db;
        public FormPeliculas()
        {
            InitializeComponent();
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            //Conexion con la base  de datos 
            db = new PetaPoco.Database("ConnectionString");
            lbListaPeliculas.DataSource = GetListaPeliculas();

        }
        //Lista de peliculas
        private List<Peliculas> GetListaPeliculas()
        {
            return db.Fetch<Peliculas>();
        }
    }
}
