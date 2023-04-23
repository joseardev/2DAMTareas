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
    public partial class FormActores : Form
    {
        Database db;
        public FormActores()
        {
            InitializeComponent();
        }

        private void FormActores_Load(object sender, EventArgs e)
        {
            //Conexion con la base de datos usando los datos de app.config
            db = new PetaPoco.Database("ConnectionString");
            lbTodosActores.DataSource = GetListaActores();
        }

        //Lista de actores de la base de datos
        private List<Actores> GetListaActores()
        {
            return db.Fetch<Actores>();
        }

        private void btCrearActor_Click(object sender, EventArgs e)
        {
            CrearActor();
        }

        private void CrearActor()
        {
            if(tbNombreActor.Text.Length > 0)
            {
                try
                {
                    //Comprobamos si existe el actor
                    if (ComprobarExisteActor(tbNombreActor.Text))
                    {
                       //creamos el actor que vamos a insertar
                        Actores actores = new Actores();
                        actores.Actor = tbNombreActor.Text;
                        //obtenemos el id
                        actores.ID = ObtenerID();
                        //Insertamos con el id como propiedad del objecto actor
                        db.Insert("Actores", "Actor", false, actores);
                        MessageBox.Show("Actor creado");
                        //Refrescamos la lista
                        lbTodosActores.DataSource = GetListaActores();
                    }
                    else
                    {
                        MessageBox.Show("Actor ya existe");
                    }
                }catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {
                MessageBox.Show("Falta nombre");
            }
                 

        }
        //Comprobamos si existe el Actor
        //devuelte true si no existe
        private bool ComprobarExisteActor(String nombreActor)
        {
          var listaActores = GetListaActores();
            int id_actual = 0;
            foreach(Actores actor  in listaActores)
            {
                //Comprobamos si existe el actor pasado por parametro
               if(actor.Actor == nombreActor)
               {
                    return false;
               }
            }
            return true;

        }
        //Obtenemos el id mas alto y se sumamos uno para el nuevo registro
        private int ObtenerID()
        {
            var listaActores = GetListaActores();
            int id_actual = 0;
            foreach (Actores actor in listaActores)
            {
                //sumamos el valor más alto para seguir comprobando con los sigueinte valores
                if (id_actual < actor.ID)
                {
                    id_actual = actor.ID;
                }
            }

            id_actual = id_actual + 1;
            return id_actual;

        }
    }
}
