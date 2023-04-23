namespace Tarea01AccesoDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEjercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 formEjercicio1 = new Ejercicio1();
            formEjercicio1.ShowDialog();    
        }

        private void btEjercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 formEjercicio2 = new Ejercicio2();  
            formEjercicio2.ShowDialog();    
        }

        private void btEjercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 formEjercicio3 = new Ejercicio3();
            formEjercicio3.ShowDialog();
        }
    }
}