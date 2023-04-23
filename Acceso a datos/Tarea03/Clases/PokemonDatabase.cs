using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Tarea03Pokemon.Clases.Modelos;

namespace Tarea03Pokemon.Clases
{
    public class PokemonDatabase
    {
        //Conexión base de datos
        SqlConnection conexion = new SqlConnection("server=localhost; database=Pokemon; integrated security = true");

        BindingList<Pokemon> ListaPokemonMostrar = new BindingList<Pokemon>();
                     List<Pokemon> listaPokemons = new List<Pokemon>();
        BindingList<Movimientos> listaMovimientos = new BindingList<Movimientos>();


        //Obtenemos Listas de pokemos desde base de datos
        //return Lista de Pokemon BindingList<Pokemon>
        public BindingList<Pokemon> listaPokemon()
        {
            try
            {
                //Abrir conexion
                conexion.Open();

                //Preparamos la consulta
                SqlCommand command = new SqlCommand(CadenasSql.SelectPokemon, conexion);
                //Ejecutamos consulta
                SqlDataReader registros = command.ExecuteReader();
                //Recorremos los registros obtenidos
                while (registros.Read())
                {
                    //Generamos objecto
                    Pokemon pk = new Pokemon();

                    pk.Numero_pokedex = (int)registros["numero_pokedex"];
                    pk.Nombre         = (string)registros["nombre"];
                    pk.Peso           = Convert.ToSingle(registros["peso"]);
                    pk.Altura         = Convert.ToSingle(registros["altura"]);
                    pk.PS             = (int)registros["ps"];
                    pk.Ataque         = (int)registros["ataque"];
                    pk.Numero_pokedex_evolucion = (int)registros["pokemon_evolucionado"];
                    pk.Pokemon_evolucionado     = (string)registros["nombre_evolucion"];

                    //Comprobamos si existen duplicados
                    var pokemon_actual = ListaPokemonMostrar.SingleOrDefault(pokemon => pokemon.Numero_pokedex == (int)registros["numero_pokedex"]);

                    if (pokemon_actual == null)
                    {
                        //generamos lista que queremos mostrar
                        ListaPokemonMostrar.Add(pk);
                    }
                    //Lista completa ya que eevee se esta repitiendo por el tipo de consulta
                    listaPokemons.Add(pk);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                //Cerramos conexion
                conexion.Close();
            }
            return ListaPokemonMostrar;
        }
        //Obtenemos Listas de pokemos desde base de datos
        //return Lista de Pokemon BindingList<Pokemon>
        public List<Pokemon> listaPokemonSinBindig()
        {
            List<Pokemon> listaPokemonSin = new List<Pokemon>();
            try
            {
               

                //Abrir conexion
                conexion.Open();

                //Preparamos la consulta
                SqlCommand command = new SqlCommand(CadenasSql.SelectPokemon, conexion);
                //Ejecutamos consulta
                SqlDataReader registros = command.ExecuteReader();
                //Recorremos los registros obtenidos
                while (registros.Read())
                {
                    //Generamos objecto
                    Pokemon pk = new Pokemon();

                    pk.Numero_pokedex = (int)registros["numero_pokedex"];
                    pk.Nombre = (string)registros["nombre"];
                    pk.Peso = Convert.ToSingle(registros["peso"]);
                    pk.Altura = Convert.ToSingle(registros["altura"]);
                    pk.PS = (int)registros["ps"];
                    pk.Ataque = (int)registros["ataque"];
                    pk.Numero_pokedex_evolucion = (int)registros["pokemon_evolucionado"];
                    pk.Pokemon_evolucionado = (string)registros["nombre_evolucion"];


                    listaPokemonSin.Add(pk);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                //Cerramos conexion
                conexion.Close();
            }
            return listaPokemonSin;
        }

        //Devuelve los ataques de un pokemon
        // numero_pokedex => numero de pokedex del pokemon
        //return => BindingList<Movimientos> objecto con los movimientos 
        public BindingList<Movimientos> GetAtaques(int numero_pokedex)
        {
            try
            {
                //Limpiamos lista
                listaMovimientos.Clear();
                //conexion base de datos
                conexion.Open();
                string cadena = "SELECT m.nombre ," +
                                       " m.descripcion " +
                                       " FROM pokemon_movimiento_forma mv FULL JOIN  movimiento m " +
                                       " ON mv.id_movimiento = m.id_movimiento" +
                                       " where mv.numero_pokedex = @numero_pokedes;";
                //Prepara consulta
                SqlCommand command = new SqlCommand(cadena, conexion);
                //remplza en la consulta el campo numero_pokedes
                command.Parameters.AddWithValue("@numero_pokedes", numero_pokedex);
                SqlDataReader movimientosBd = command.ExecuteReader();
               //Recorremos los datos obtenidos 
                while (movimientosBd.Read())
                {
                    //Generamos objecto y almacenamos en la lista
                    Movimientos movimientos = new Movimientos();
                    movimientos.Nombre = (string)movimientosBd["nombre"];
                    movimientos.Descripcion = (string)movimientosBd["descripcion"];
                    listaMovimientos.Add(movimientos);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                //Cerramos conexion
                conexion.Close();
            }

            return listaMovimientos;
        }
        //param 
        // numero_pokedex => numero de pokedex del pokemon        
        public BindingList<Pokemon> ObtenerEvolucionesFinales(int numero_pokedex)
        {
            BindingList<Pokemon> evolucionesSiguientesPokemon = new BindingList<Pokemon>();
            try
            {
                conexion.Open();
                evolucionesSiguientesPokemon.Clear();
                var existeEvolucion = true;
                int contador = 0;
                //Recoremos la lista de pokemos que tenemos en memoria
                foreach (Pokemon pk in listaPokemons)
                {
                 //Comprobamos cuantas veces aparece el pokemon 
                    if (pk.Numero_pokedex == numero_pokedex)
                    {
                        //Si existe > 1 es que tiene varias evoluciones desde el mismo numero de pokedex 
                        //Entonces se genera la lista con sus evoluciones
                        var pokemon_evolucion = listaPokemons.SingleOrDefault(pokemon => pokemon.Numero_pokedex == pk.Numero_pokedex_evolucion);                        
                        evolucionesSiguientesPokemon.Add(pokemon_evolucion);
                        contador += 1;
                    }
                }

                //Si contador es 1 quiere decir que es un pokemos con evoluciones consecutivas
                if (contador == 1)
                {
                    evolucionesSiguientesPokemon.Clear();
                    var pokemon_actual = listaPokemons.SingleOrDefault(pokemon => pokemon.Numero_pokedex == numero_pokedex);
                    while (existeEvolucion)
                    {

                        if (pokemon_actual.Numero_pokedex_evolucion > 0)
                        {
                            //Obtenemos el pokemon pasando el nuermo de pokedex evolucion del pokemos pasado como parametro
                            var pokemon_evolucion = listaPokemons.SingleOrDefault(pokemon => pokemon.Numero_pokedex == pokemon_actual.Numero_pokedex_evolucion);
                            evolucionesSiguientesPokemon.Add(pokemon_evolucion);
                            //cargamos el pokemos obtenido para buscar en la siguiente vuelta si tiene evolucion
                            pokemon_actual = pokemon_evolucion;
                        }
                        else
                        {
                            //ya tiene todas las evoluciones o no tiene
                            existeEvolucion = false;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return evolucionesSiguientesPokemon;
        }

        public BindingList<Pokemon> ObtenerEvolucionesPreviasPokemon(int numero_pokedex)
        {
            BindingList<Pokemon> evolucionesPreviasPokemon = new BindingList<Pokemon>();
            try
            {
                evolucionesPreviasPokemon.Clear();
                var existeEvolucion = true;
                //Comprobamos si tiene evoluciones
                var pokemon_actual = listaPokemons.SingleOrDefault(pokemon => pokemon.Numero_pokedex_evolucion == numero_pokedex);

                // si es null seguimos ya que no tiene evoluciones
                if (pokemon_actual != null)
                {
                    //si tiene la añadimos a la lista
                    evolucionesPreviasPokemon.Add(pokemon_actual);
                    while (existeEvolucion)
                    {
                        //Buscamos si tiene más
                        if (pokemon_actual.Numero_pokedex > 0)
                        {
                            var pokemon_evolucion = listaPokemons.SingleOrDefault(pokemon => pokemon.Numero_pokedex_evolucion == pokemon_actual.Numero_pokedex);
                            //Si tiene mas se añade a la lista
                            if (pokemon_evolucion != null)
                            {
                                evolucionesPreviasPokemon.Add(pokemon_evolucion);
                                pokemon_actual = pokemon_evolucion;
                            }
                            else
                            {
                                existeEvolucion = false;
                            }
                        }
                        else
                        {
                            existeEvolucion = false;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            
            return evolucionesPreviasPokemon;


        }

        //Genera la lista de pokemos según los filtros pasados como parametros
        public void FiltrarListaPokemon(string tipo, float peso, float altura)
        {
            try
            {
                conexion.Open();
                ListaPokemonMostrar.Clear();
                string cadena = CadenasSql.SelectPokemonNoWhere;
                //Generamos este linea para poder concatenar el resto
                cadena += " WHERE 1=1 ";

                //Comprobamos los valores y si tenemos los añadimso en la consulta.
                if (tipo != "")
                {
                    cadena += " and p.numero_pokedex in (select tip.numero_pokedex from dbo.pokemon_tipo tip where tip.id_tipo in (select tipo.id_tipo from dbo.tipo tipo where tipo.nombre = @tipo )) ";
                }

                if (peso > 0)
                {
                    cadena += " AND peso =  @peso";
                }
                if (altura > 0)
                {
                    cadena += " AND altura =  @altura";
                }
                //Ultima linea para ordenar los resultados
                cadena += " order by numero_pokedex asc;";

                //Generamos las consulta
                SqlCommand command = new SqlCommand(cadena, conexion);

                //Añadimos los parametros según tengamos valores
                if (tipo != "")
                {
                    command.Parameters.AddWithValue("@tipo", tipo);
                }

                if (peso > 0)
                {
                    command.Parameters.AddWithValue("@peso", peso);
                }
                if (altura > 0)
                {
                    command.Parameters.AddWithValue("@altura", altura);
                }

                SqlDataReader registros = command.ExecuteReader();
                //Recoremos los resultados
                while (registros.Read())
                {
                    //Generamos objectos con los resultados y los almacenamos 
                    Pokemon pk = new Pokemon();

                    pk.Numero_pokedex = (int)registros["numero_pokedex"];
                    pk.Nombre = (string)registros["nombre"];
                    pk.Peso = Convert.ToSingle(registros["peso"]);
                    pk.Altura = Convert.ToSingle(registros["altura"]);
                    pk.PS = (int)registros["ps"];
                    pk.Numero_pokedex_evolucion = (int)registros["pokemon_evolucionado"];
                    pk.Pokemon_evolucionado = (string)registros["nombre_evolucion"];
                    
                    //Quitamos duplicados
                    var pokemon_actual = ListaPokemonMostrar.SingleOrDefault(pokemon => pokemon.Numero_pokedex == (int)registros["numero_pokedex"]);
                    if (pokemon_actual == null)
                    {
                        ListaPokemonMostrar.Add(pk);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        ///Obteners Tipos        
        public List<Tipos> GetTipos()
        {
            List<Tipos> listaTipos = new List<Tipos>();
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand(CadenasSql.SelectTipos, conexion);
                SqlDataReader tiposBD = command.ExecuteReader();

                //Añadimos esta linea para generar la primera en blanco para el comboBox
                Tipos tipo1 = new Tipos();
                tipo1.Nombre = "";                
                listaTipos.Add(tipo1);
                //recoremos resultados
                while (tiposBD.Read())
                {
                    //generamos los objectos y los almacenamos
                    Tipos tipo = new Tipos();
                    tipo.Nombre = (string)tiposBD["nombre"];                    
                    listaTipos.Add(tipo);
                }
                tiposBD.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la consulta SQL: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("La conexión a la base de datos no se ha establecido o ya está cerrada: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Uno de los parámetros proporcionados a la consulta SQL no es válido: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return listaTipos;
        }

    }
}


