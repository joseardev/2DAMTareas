package com.tarea2.tarea3;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Objects;

public class MainActivity extends AppCompatActivity {
    private String nombreBD = "jose";
    AdminBD admin = new AdminBD(this, nombreBD, null, 1);
    ArrayList<Cita> listaCitas = new ArrayList<>();
    ListView lista;
    private EditText edNombreCliente, edAsunto, edTelefono;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Objects.requireNonNull(getSupportActionBar()).setTitle("Citas ");
        edNombreCliente = (EditText) findViewById(R.id.edNombreCliente);
        edAsunto = (EditText) findViewById(R.id.edAsunto);
        edTelefono = (EditText) findViewById(R.id.edTelefono);
        Button btAddCita = (Button) findViewById(R.id.btAddCita);

        btAddCita.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                alta();
            }
        });
        //Iniciamos adaptador
        //listaCitas.add(new Cita(1,"30","12","asd",444));
        AdaptadorCitas adaptador = new AdaptadorCitas(this, listaCitas);
        //Lista
        lista = (ListView) findViewById(R.id.lista);
        lista.setAdapter(adaptador);
        consultaAllCitas();
    }
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Manejar los clics de elementos del menú de la barra de acción y de la barra de opciones.
        int id = item.getItemId();
        if (id == R.id.alta) {
            Intent intent = new Intent(this, BuscadorCitas.class);
            this.startActivity(intent);
        }

        return super.onOptionsItemSelected(item);
    }
    //Alta Cita
    public void alta() {

        //Comprobamos que tenemos los valores necesarios
        if (edNombreCliente.getText().toString().length() > 0 
                &&  edTelefono.getText().toString().length() > 0
                &&  edAsunto.getText().toString().length() > 0){

            SQLiteDatabase bd;
            try {
                //Obtenemos hora y fecha actual para guardar la cita
                SimpleDateFormat simpleFechaFormat = new SimpleDateFormat("dd/MM/yyyy");
                String fecha = simpleFechaFormat.format(new Date());
                SimpleDateFormat simpleHoraFormat = new SimpleDateFormat("HH:mm:ss");
                String hora = simpleHoraFormat.format(new Date());
                //Comprobamos si existe cita en la misma fecha
                if(compruebaExisteCitaEnFechas(fecha)){

                    bd = admin.getWritableDatabase();
                    if (bd != null) {
                        String nombreCliente = edNombreCliente.getText().toString();
                        String asunto = edAsunto.getText().toString();
                        String telefono = edTelefono.getText().toString();
                        int tlfInt=0;
                        try {
                            //Comprobamos si telefono tiene valores numericos
                            tlfInt= Integer.parseInt(telefono);
                        } catch (NumberFormatException e) {
                            Toast.makeText(this, "Telefono incorrecto", Toast.LENGTH_SHORT).show();
                            return;
                        }
                        //Objecto para realizar el insert
                        ContentValues registro = new ContentValues();
                        registro.put("nombre", nombreCliente);
                        registro.put("asunto", asunto);
                        registro.put("telefono", tlfInt);
                        registro.put("fecha", fecha);
                        registro.put("hora", hora);
                        // Toast.makeText(this, fecha, Toast.LENGTH_SHORT).show();
                        bd.insert("tarea3", null, registro);
                        bd.close();
                        //Limpiamos layout despues de la inserción
                        edNombreCliente.setText("");
                        edAsunto.setText("");
                        edTelefono.setText("");
                        //Recargamos la lista con la cita nueva
                        consultaAllCitas();
                        Toast.makeText(MainActivity.this, "Se grabaron los datos de la cita", Toast.LENGTH_SHORT).show();
                } else {
                        Toast.makeText(this, "Base de datos no creada", Toast.LENGTH_SHORT).show();
                    }
            }else {
                Toast.makeText(this, "Ya existe una cita en las fecha actual", Toast.LENGTH_SHORT).show();
    }
            } catch (SQLiteException ex) {
                bd = admin.getReadableDatabase();
                Toast.makeText(this, "No se puede escribir la Base de Datos", Toast.LENGTH_SHORT).show();
                bd.close();
            }
        }else{
            Toast.makeText(this, "Faltan campos por completar", Toast.LENGTH_SHORT).show();
        }
    }

    //Consulta todas las citas de la tabla tarea3
    public void consultaAllCitas() {

        ArrayList<Cita> listado = new ArrayList<>();
        SQLiteDatabase bd = admin.getReadableDatabase();
        Cursor cursor = bd.rawQuery("select codigo,nombre,asunto,fecha,hora,telefono from tarea3", null);
        //LIm
        listaCitas.clear();
        while(cursor.moveToNext()) {
            int numCita = cursor.getInt(cursor.getColumnIndexOrThrow("codigo"));
            String nombreCliente = cursor.getString(cursor.getColumnIndexOrThrow("nombre"));
            String asunto = cursor.getString(cursor.getColumnIndexOrThrow("asunto"));
            String fecha = cursor.getString(cursor.getColumnIndexOrThrow("fecha"));
            String hora = cursor.getString(cursor.getColumnIndexOrThrow("hora"));
            int telefono = cursor.getInt(cursor.getColumnIndexOrThrow("telefono"));

            AdaptadorCitas adaptador = new AdaptadorCitas(this, listaCitas);
            lista.setAdapter(adaptador);

            listaCitas.add(new Cita(numCita,fecha,nombreCliente,asunto,telefono,hora));
            adaptador.notifyDataSetChanged();
        }
        cursor.close();
        bd.close();
    }
    //Comprueba existen citas
    public boolean compruebaExisteCitaEnFechas(String fecha) {

        ArrayList<Cita> listado = new ArrayList<>();
        SimpleDateFormat simpleHoraFormat = new SimpleDateFormat("HH:mm");
        String hora = simpleHoraFormat.format(new Date());
        SQLiteDatabase bd = admin.getReadableDatabase();
        String[] args = new String[]{fecha,"%"+hora+"%"};
        Cursor cursor = bd.rawQuery("select codigo from tarea3 where  fecha = ? and hora like ? ", args);

        if(cursor.getCount()> 0){
            return false;
        }

        cursor.close();
        bd.close();
        return true;
    }



}