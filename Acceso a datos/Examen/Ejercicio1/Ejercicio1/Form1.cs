using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        BindingList<string> listFicherosCargados = new BindingList<string>();

        BindingList<string> listContenidoFicheros = new BindingList<string>();
        List<Nomina> listNominas = new List<Nomina>();
        Database db;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbFicherosCargados.DataSource = listFicherosCargados;
            lbDatosFicheros.DataSource = listContenidoFicheros;
            try
            {
                db = new PetaPoco.Database("ConnectionString");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
        private void btCargarFicheros_Click(object sender, EventArgs e)
        {

            CargarFicheroNominas();


        }

        private void CargarFicheroNominas()
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (folderBrowserDialog.SelectedPath != null)
                    {
                        tbRutaNominas.Text = folderBrowserDialog.SelectedPath;
                        var rutaCarpeta = folderBrowserDialog.SelectedPath;
                        var ficheros = Directory.EnumerateFiles(rutaCarpeta, "*.txt");

                        foreach (string currectFile in ficheros)
                        {

                            var resultado = currectFile;
                            string filename = currectFile.Substring(rutaCarpeta.Length + 1);
                            listFicherosCargados.Add(filename);

                            MostrarContenidoFicheros(currectFile);
                            File.Delete(currectFile);

                        }
                        MessageBox.Show("Proceso finalizado correctamente. Los ficheros de nominas fueron borrados");

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void MostrarContenidoFicheros(string rutaFichero)
        {
            StreamReader ficheroLectura;
            //Cargamos fichero en memoria
            ficheroLectura = File.OpenText(rutaFichero);
            //Recoremos el fichero
            //int contador = 
            Nomina nuevaNomina = new Nomina();
            while (!ficheroLectura.EndOfStream)
            {

                //Obtenemos línea actual
                string linea = ficheroLectura.ReadLine();
                var lineaSinEspacios = linea.Replace(" ", "");
                var tipo = lineaSinEspacios.Substring(0, 5);
                if (tipo == "Nombr")
                {
                    nuevaNomina.NombreEmpleado = lineaSinEspacios.Substring(17 + 1);
                }
                else if (tipo == "IDdel")
                {
                    nuevaNomina.IDEmpleado = linea.Substring(16 + 1);
                }
                else if (tipo == "Fecha")
                {
                    if (nuevaNomina.NombreEmpleado == null)
                    {
                        nuevaNomina.NombreEmpleado = "null";
                    }
                    if (nuevaNomina.IDEmpleado == null)
                    {
                        nuevaNomina.IDEmpleado = "1111";
                    }
                    if (nuevaNomina.FechaPago == null)
                    {
                        nuevaNomina.FechaPago = "31/03/2023";
                    }
                    nuevaNomina.SalarioBase = 29292;
                    nuevaNomina.DiasTrabajados = 2;
                    nuevaNomina.HorasExtra = 80;
                    nuevaNomina.SalarioPorHora = 222;
                    nuevaNomina.SalarioPorHoraExtra = 222;
                    //falta
                    nuevaNomina.Asignaciones = 23;
                    nuevaNomina.Deducciones = 222;
                    nuevaNomina.TotalDevengado = 22;
                    listNominas.Add(nuevaNomina);
                    db.Save(nuevaNomina);
                    lbNominasGuardadas.Items.Add("NOMINA: " + nuevaNomina.NombreEmpleado);
                }

                listContenidoFicheros.Add(linea);


            }
            ficheroLectura.Close();


        }


    }
}
