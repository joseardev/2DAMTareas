
using System.Collections;

namespace Tarea03Pokemon.Clases
{
    public class Pokemon
    {
        int numero_pokedex;
        string nombre;
        float peso;
        float altura;
        int numero_pokedex_evolucion;
        string nombre_evolucion;

        ArrayList MovimientosDisponibles = new ArrayList();

        public int Numero_pokedex { get => numero_pokedex; set => numero_pokedex = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }
        public int Numero_pokedex_evolucion { get => numero_pokedex_evolucion; set => numero_pokedex_evolucion = value; }

        public string Pokemon_evolucionado { get => nombre_evolucion; set => nombre_evolucion = value; }



        public int PS { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Especial { get; set; }
        public int Velocidad { get; set; }

        public int Id_tipo { get; set; }
        public string Tipo { get; set; }


        public Pokemon()
        {

        }
        public Pokemon(int numero_pokedex, string nombre, float peso, float altura)
        {
            this.Numero_pokedex = numero_pokedex;
            this.Nombre = nombre;
            this.Peso = peso;
            this.Altura = altura;
        }

        public override string ToString()
        {
            return this.Nombre + " peso => " + this.peso;
        }
    }
}
