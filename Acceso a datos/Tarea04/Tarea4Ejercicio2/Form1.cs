using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4Ejercicio2
{
    public partial class Form1 : Form
    {
        Database db;

        BindingList<Equipo> equipos = new BindingList<Equipo>();
        public Form1()
        {
            InitializeComponent();
            db = new PetaPoco.Database("ConnectionString");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializamos
            //las listas
            lbEQuipos.DataSource = GetListaEquipos();            
            lbFutbolistas.DataSource = GetListaFutbolistas();            
            //ComboBox
            cbEquipos.DataSource = GetListaEquipos();
            cbFutbolistas.DataSource = GetListaFutbolistas();
            cbEquiposModificar.DataSource = GetListaEquipos();
        }       
     

        //Borrar el equipo pasado por parametro
        //param 
        //equipo => Objecto Equipo 
        private void borrarEquipos(Equipo equipo)
        {
            try
            {
                // Borrar el registro usando el método Delete
                db.Delete<Futbolista>("WHERE codigoEquipo = @0", equipo.Codigo);
                db.Delete(equipo);
                lbEQuipos.DataSource = GetListaEquipos();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Modificar  equipo
        //param 
        //equipo => Objecto Equipo 
        private void UpdateEquipos(Equipo equipo)
        {
            try
            {         
                db.Update("Equipos", "Codigo", equipo);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }



        //Insertar equipo nuevo
        //param
        // equipo => nuevo equipo
        private void InsertEquipos(Equipo equipo)
        {
            try
            {
                // "Equipos" es el nombre de la tabla, "Codigo" es el nombre de la columna de clave primaria, "true"
                // indica que la clave primaria no es autonumérica, y "equipo" es el objeto que se va a insertar
                db.Insert("Equipos", "Codigo", false, equipo);
            }                       
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }


        /// Obtener lista de equipos        
        /// return List<Equipo>
        public List<Equipo> GetListaEquipos()
        {           
            return db.Fetch<Equipo>().ToList();                       
        }

        /// Obtener lista de Futbolista        
        /// return List<Futbolista>
        public List<Futbolista> GetListaFutbolistas()
        {
            return db.Fetch<Futbolista>().ToList();
        }
        
        private void btBorrarEquipo_Click(object sender, EventArgs e)
        {
            BorrarEquipo();
        }
              
        private void BorrarEquipo()
        {

            try
            {
                // Crear una instancia del objeto Equipo que quieres borrar
                var equipo = (Equipo)lbEQuipos.SelectedItem;
                if (equipo != null)
                {
                    borrarEquipos(equipo);
                    lbEQuipos.DataSource = GetListaEquipos();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void btBorrarFutbolista_Click(object sender, EventArgs e)
        {
            var futbolista = (Futbolista)lbFutbolistas.SelectedItem;
            if(futbolista != null)
            {
                BorrarFutbolista(futbolista);
                lbFutbolistas.DataSource = GetListaFutbolistas();
            }            
        }

        //Borrar Futbolista
        private void BorrarFutbolista(Futbolista futbolista)
        {
            // Borrar el registro usando el método Delete
            db.Delete(futbolista);
            lbFutbolistas.DataSource = GetListaFutbolistas();
        }

        private void btAddEquipo_Click(object sender, EventArgs e)
        {

            int golesEquipo;
            bool success = int.TryParse(tbGolesEquipo.Text, out golesEquipo);
            if (success && tbCodigoEquipo.Text.Length > 0 && tbNombreEquipo.Text.Length > 0)
            {
                var equipo = new Equipo
                {
                    Codigo = tbCodigoEquipo.Text,
                    Nombre = tbNombreEquipo.Text,
                    Pais = tbPaisEquipo.Text,
                    Goles = golesEquipo,
                    Puntos = 0,
                    PJ = "0",
                    PG = 0,
                    PE = 0,
                    PP = 0                   
                };
                InsertEquipos(equipo);
                lbEQuipos.DataSource = GetListaEquipos();
            }
            else
            {
                MessageBox.Show("Faltan datos o son incorrectos");
            }

        }

        private void btAddFutbolista_Click(object sender, EventArgs e)
        {
            var equipo = (Equipo)cbEquiposModificar.SelectedItem;
            if (equipo != null && tbCodigoFut.Text.Length > 0 && tbNombreFut.Text.Length > 0)
            {            
                var futbolista = new Futbolista
                {
                    Codigo = tbCodigoFut.Text,
                    Nombre = tbNombreFut.Text,
                    CodigoEquipo = equipo.Codigo,
                    Posicion = tbPosicionFut.Text,
                    Edad = 0,
                    Goles = 0,
                    TA = 0,
                    TR = 0,
                    Minutos = 0,
                    PrecioMercado = "Estadio 1",
                    Dorsal = 10,
                    Peso = 10
                };

                InsertFutbolista(futbolista);
                lbFutbolistas.DataSource = GetListaFutbolistas();
            }
            else
            {
                MessageBox.Show("Faltan datos o son incorrectos");
            }
        }

        /// inserta fubolista
        /// 
        /// futbolista => 
        private void InsertFutbolista(Futbolista futbolista)
        {
            try
            {
                db.Insert("Futbolistas", "Codigo", false, futbolista);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btModificarEquipos_Click(object sender, EventArgs e)
        {
            var equipo = (Equipo)lbEQuipos.SelectedItem;
            FormModificarEquipo formModificarEquipo = new FormModificarEquipo();            
            formModificarEquipo.Owner = this;
            formModificarEquipo.ShowDialog();
        }


        public  Equipo GetEquipoLista()
        {
            return (Equipo)lbEQuipos.SelectedItem;
        }
        public Futbolista GetFutbolistaLista()
        {
            return (Futbolista)lbFutbolistas.SelectedItem;
        }

        public void UpdateEquipo(Equipo equipo)
        {
            UpdateEquipos(equipo);
            lbEQuipos.DataSource = GetListaEquipos();
        }

        private void btModificarFutbolista_Click(object sender, EventArgs e)
        {
            FormModificarFutbolista formModificarFutbolista = new FormModificarFutbolista();
            formModificarFutbolista.Owner = this;
            formModificarFutbolista.ShowDialog();

        }

        public void ModificarFutbolista(Futbolista futbolista) {

            UpdateFutbolista(futbolista);
            lbFutbolistas.DataSource = GetListaFutbolistas();
        }

        private void UpdateFutbolista(Futbolista futbolista)
        {
            try
            {
                db.Update("Futbolistas", "Codigo", futbolista);
            }
            catch (SqlException e )
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private List<Futbolista> ObtenerFutbolistasPorEquipo(Equipo equipo)
        {
            List<Futbolista> futbolista = new List<Futbolista>();
            try
            {
                futbolista = db.Fetch<Futbolista>("where CodigoEquipo in (select codigo from equipos where codigo = @0)", equipo.Codigo);                
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return futbolista;
        }        

        private List<Equipo> ObtenerEquipoDeFutbolista(Futbolista futbolista)
        {
            List<Equipo> equipos = new List<Equipo>();
            try
            {
                //comprobamos en la tabla furbolistas si existe el codigo del futbolista selecionado
                equipos = db.Fetch<Equipo>("WHERE codigo in (Select codigoEquipo from futbolistas WHERE codigo = @0)", futbolista.Codigo);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return equipos;
        }

        private void btBuscarFutbolistas_Click(object sender, EventArgs e)
        {
            BuscarFutbolistaByEquipo();
        }
        private void btBuscarEquipos_Click(object sender, EventArgs e)
        {
            BuscarEquipoByFutbolistas();
        }

        //Obtiene el equipo del combobox
        private void BuscarEquipoByFutbolistas()
        {
            var equipo = (Futbolista)cbFutbolistas.SelectedItem;
            lbEQuipos.DataSource = ObtenerEquipoDeFutbolista(equipo);

        }

        //Obtiene el equipo del combobox
        private void BuscarFutbolistaByEquipo()
        {            
            var equipo = (Equipo)cbEquipos.SelectedItem;
            lbFutbolistas.DataSource = ObtenerFutbolistasPorEquipo(equipo);

        }

    
    }
}
