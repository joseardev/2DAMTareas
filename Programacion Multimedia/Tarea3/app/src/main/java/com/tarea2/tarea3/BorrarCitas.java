package com.tarea2.tarea3;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Objects;

public class BorrarCitas extends AppCompatActivity{

    private TextView tvNombreCliente, tvAsunto, tvTelefono, tvHora, tvFecha;

    ArrayList<Cita> listaCitas = new ArrayList<>();
    private String nombreBD = "jose";
    private int posicion  =0;
    AdminBD admin = new AdminBD(this, nombreBD, null, 1);
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_borrar_citas);
        Objects.requireNonNull(getSupportActionBar()).hide();
        tvNombreCliente = (TextView) findViewById(R.id.tvNombre);
        tvAsunto = (TextView) findViewById(R.id.tvAsunto);
        tvTelefono = (TextView) findViewById(R.id.tvTelefono);
        tvFecha = (TextView) findViewById(R.id.tvFecha);
        tvHora = (TextView) findViewById(R.id.tvHora);
        Button btBorrarCita = (Button) findViewById(R.id.btEliminar);
        btBorrarCita.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //obtenemos posicion lista
                Cita citaActual = listaCitas.get(posicion);
                CitaDao.bajaCitasPorFechaHora(view.getContext(),citaActual.getFechaCita(),citaActual.getHora());
                AlertDialog.Builder builder = new AlertDialog.Builder(view.getContext());
                builder.setMessage("Cita borrada")
                        .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int id) {
                                Intent intent = new Intent(view.getContext(), MainActivity.class);
                                startActivity(intent);
                            }
                        });
                AlertDialog alert = builder.create();
                alert.show();
            }
        });

        // Obtener el valor del parámetro
        posicion = getIntent().getIntExtra("posicion",0);
        consultaTodosold();
        setLayout(posicion);
    }
    public void consultaTodosold() {


        SQLiteDatabase bd = admin.getReadableDatabase();
        Cursor cursor = bd.rawQuery("select codigo,nombre,asunto,fecha,hora,telefono from tarea3", null);
        int resultado = cursor.getColumnIndexOrThrow("codigo");
        listaCitas.clear();
        while(cursor.moveToNext()) {
            int numCita = cursor.getInt(cursor.getColumnIndexOrThrow("codigo"));
            String nombreCliente = cursor.getString(cursor.getColumnIndexOrThrow("nombre"));
            String asunto = cursor.getString(cursor.getColumnIndexOrThrow("asunto"));
            String fecha = cursor.getString(cursor.getColumnIndexOrThrow("fecha"));
            String hora = cursor.getString(cursor.getColumnIndexOrThrow("hora"));
            int telefono = cursor.getInt(cursor.getColumnIndexOrThrow("telefono"));

            listaCitas.add(new Cita(numCita,fecha,nombreCliente,asunto,telefono,hora));
        }
        cursor.close();
        bd.close();
    }

    private void setLayout(int posicion){

        Cita nuevaCita = listaCitas.get(posicion);
        tvNombreCliente.setText(nuevaCita.getNombreCliente());
        tvAsunto.setText(nuevaCita.getAsunto());
        int resultado = nuevaCita.getTelefonoCliente();
        tvTelefono.setText(String.valueOf(resultado));
        tvFecha.setText(nuevaCita.getFechaCita());
        tvHora.setText(nuevaCita.getHora());

    }

    private void borrarCita(){

    }
}