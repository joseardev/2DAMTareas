package com.tarea2.tarea2;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import com.tarea2.tarea2.clases.AdaptadorJugadores;
import com.tarea2.tarea2.clases.Jugadores;

import java.util.ArrayList;
import java.util.Objects;

public class MainActivity extends AppCompatActivity {

    Jugadores jugadorActual;
    EditText nombreJugador;
    EditText edad;
    EditText numero;
    int posicionActual;
    Spinner spinner;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Objects.requireNonNull(getSupportActionBar()).setTitle("FutiBoles ");
        ArrayList<Jugadores> listaEmpleados = new ArrayList<>();

        //Logos iniciales
        int logo_celta = R.drawable.logo_celta;
        int logo_barca = R.drawable.logo_barca;
        int logo_madrid = R.drawable.real_madrid;

        //Lista de jugadores
        listaEmpleados.add(new Jugadores("Aspas","30","12",logo_celta));
        listaEmpleados.add(new Jugadores("Messi","20","54",logo_barca));
        listaEmpleados.add(new Jugadores("Vini","41","10",logo_madrid));
        listaEmpleados.add(new Jugadores("Raúl","45","16",logo_celta));
        listaEmpleados.add(new Jugadores("Benzema","40","1",logo_madrid));
        listaEmpleados.add(new Jugadores("Pablo","41","5",logo_barca));
        listaEmpleados.add(new Jugadores("Raul","25","7",logo_madrid));
        listaEmpleados.add(new Jugadores("Chema","45","50",logo_celta));
        listaEmpleados.add(new Jugadores("Paticorto","30","88",logo_barca));


       //Iniciamos adaptador
        AdaptadorJugadores adaptador = new AdaptadorJugadores(this, listaEmpleados);

        //Lista
        ListView lista = (ListView) findViewById(R.id.lista);

        //Editext
        nombreJugador = (EditText) findViewById(R.id.tvNombreJugador);
        edad = (EditText) findViewById(R.id.tvEdad);
        numero = (EditText) findViewById(R.id.edNumero);
        //Botones
        Button modificar = (Button) findViewById(R.id.btModificar);

        //Spinner
        spinner = findViewById(R.id.spEquipo);
        //Crea un ArrayAdapter usando el array de cadenas y un layout de spinner por defecto.
        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(this,
                R.array.equipos, android.R.layout.simple_spinner_item);
        // especificamos como queremos mostrar el spinner
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        //Aplicamos el adaptar al spinner
        spinner.setAdapter(adapter);
        //Aplicamos el adaptar a la lista
        lista.setAdapter(adaptador);

        ///Disparador cuando pulsamos un elemento de la lista
        lista.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                //Obtenemos jugador seleccionado
                jugadorActual = listaEmpleados.get(position);
                if(jugadorActual != null){
                    //Mostramos los datos
                    nombreJugador.setText(jugadorActual.getNombre());
                    edad.setText(jugadorActual.getEdad());
                    numero.setText(jugadorActual.getNumero());
                    posicionActual = position;
                    spinner.setSelection(ObtenerEquipoPosicionSpinner(jugadorActual.getLogo()));}
                }
        });
        
        modificar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Datos actuales
                String nombre = nombreJugador.getText().toString();
                String edadActual = edad.getText().toString();
                String numeroActual = numero.getText().toString();
                //Comprobamos que los datos son correctos
                if (nombre.length() > 0 && edadActual.toString().length() > 0 && numeroActual.length() > 0 ){
                    Jugadores newJogador = new Jugadores(nombre,edadActual,numeroActual,ObtenerLogoEquipo(spinner.getSelectedItem().toString()));
                    Jugadores resultado = listaEmpleados.set(posicionActual,newJogador);
                    //Refrescamos Listview
                    adaptador.notifyDataSetChanged();
                    Toast.makeText(MainActivity.this, "Jugador "+ nombre +" Modificado ", Toast.LENGTH_SHORT).show();
                }
                Toast.makeText(MainActivity.this, "Faltan datos ", Toast.LENGTH_SHORT).show();
            }
        });
    }
    //Obtener int del logo pasado como parametro de la carpeta drawable
    private int ObtenerLogoEquipo(String logoSeleccionado){
        int numLogo = 0;
        switch (logoSeleccionado) {
            case "logo_celta":
                numLogo = R.drawable.logo_celta;
                break;
            case "logo_barca":
                numLogo = R.drawable.logo_barca;
                break;
            case "real_madrid":
                numLogo = R.drawable.real_madrid;
                break;
        }
        return numLogo;
    }

    //Nos devuelve la posición del logo pasado como parametro en el spinner
    private int ObtenerEquipoPosicionSpinner(int logoJugador){
        int numLogo = 0;
        if (logoJugador == R.drawable.real_madrid){
            numLogo = 0;
        } else if (logoJugador == R.drawable.logo_celta) {
            numLogo = 1;
        } else if (logoJugador == R.drawable.logo_barca) {
            numLogo = 2;
        }
        return numLogo;
    }

}