package com.tarea2.tarea3;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.app.TimePickerDialog;
import android.content.ContentValues;
import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TimePicker;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Locale;
import java.util.Objects;

public class BuscadorCitas extends AppCompatActivity {
    ListView lista;
    ArrayList<Cita> listaCitas = new ArrayList<>();
    private String nombreBD = "jose";
    private EditText tvFecha, tvHora;
    private EditText edNombreCliente, edAsunto,edObservaciones, edTelefono, edHora, edFecha, edCita;
    AdminBD admin = new AdminBD(this, nombreBD, null, 1);
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_buscador_citas);
        Objects.requireNonNull(getSupportActionBar()).setTitle("Buscar Citas ");
        tvFecha = (EditText) findViewById(R.id.tvFecha);
        tvHora = (EditText) findViewById(R.id.tvHora);


        edNombreCliente = (EditText) findViewById(R.id.edNombreCliente);
        edAsunto = (EditText) findViewById(R.id.edAsunto);
        edTelefono = (EditText) findViewById(R.id.edTelefono);
        edFecha = (EditText) findViewById(R.id.edFecha);
        edHora = (EditText) findViewById(R.id.edHora);
        edCita = (EditText) findViewById(R.id.edCita);

        setupFechaHora();

        tvFecha.setOnClickListener(v -> setupFechaHora());

        Button btAddCita = (Button) findViewById(R.id.btBuscador);
        btAddCita.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                consultaporFecha(tvFecha.getText().toString(), tvHora.getText().toString());
            }
        });

        Button btModificar = (Button) findViewById(R.id.btModificar);
        btModificar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                modificacion(tvFecha.getText().toString(),tvHora.getText().toString());
                AlertDialog.Builder builder = new AlertDialog.Builder(view.getContext());
                builder.setMessage("Cita modificada")
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

    }

    private void setupFechaHora(){
        // Crear un calendario con la fecha actual
        final Calendar calendar = Calendar.getInstance();

        // Crear un DatePickerDialog que muestre el calendario
        DatePickerDialog datePickerDialog = new DatePickerDialog(
                this,
                (view, year, month, dayOfMonth) -> {
                    // El usuario ha seleccionado una hora
                    // Asignar la hora seleccionada al EditText
                    String fecha = String.format(Locale.getDefault(), "%02d/%02d/%04d", dayOfMonth, month + 1, year);
                    tvFecha.setText(fecha);
                    // Crear un calendario con la fecha actual
                    final Calendar calendar1 = Calendar.getInstance();

                    // Crear un TimePickerDialog que muestre el selector de hora
                    TimePickerDialog timePickerDialog = new TimePickerDialog(
                            view.getContext(),
                            (view1, hourOfDay, minute) -> {
                                // El usuario ha seleccionado una hora
                                // Asignar la hora seleccionada al EditText
                                String hora = String.format(Locale.getDefault(), "%02d:%02d", hourOfDay, minute);
                                tvHora.setText(hora);
                            },
                            calendar1.get(Calendar.HOUR_OF_DAY),
                            calendar1.get(Calendar.MINUTE),
                            false);

                    // Mostrar el TimePickerDialog
                    timePickerDialog.show();
                },
                calendar.get(Calendar.YEAR),
                calendar.get(Calendar.MONTH),
                calendar.get(Calendar.DAY_OF_MONTH));
        // Mostrar el DatePickerDialog
        datePickerDialog.show();
    }
    public void consultaporFecha(String fecha_filtro, String hora_filtro) {
        ArrayList<Cita> listado = new ArrayList<>();

        SQLiteDatabase bd = admin.getReadableDatabase();
        String[] args = new String[]{fecha_filtro,"%"+hora_filtro+"%"};
        Cursor cursor = bd.rawQuery("select codigo,nombre,asunto,fecha,hora,telefono from tarea3 where  fecha = ? and hora like ? ", args);

        while(cursor.moveToNext()) {
            int numCita = cursor.getInt(cursor.getColumnIndexOrThrow("codigo"));
            String nombreCliente = cursor.getString(cursor.getColumnIndexOrThrow("nombre"));
            String asunto = cursor.getString(cursor.getColumnIndexOrThrow("asunto"));
            String fecha = cursor.getString(cursor.getColumnIndexOrThrow("fecha"));
            String hora = cursor.getString(cursor.getColumnIndexOrThrow("hora"));
            int telefono = cursor.getInt(cursor.getColumnIndexOrThrow("telefono"));
            edNombreCliente.setText(nombreCliente);
            edTelefono.setText(telefono+"");
            edAsunto.setText(asunto);
            edFecha.setText(fecha);
            edHora.setText(hora);
            edCita.setText(numCita+"");
        }

        cursor.close();
        bd.close();
    }
    public void modificacion(String fecha,String hora) {
        AdminBD admin = new AdminBD(this, nombreBD, null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        if (bd != null) {
            ContentValues values = new ContentValues();
            values.put("nombre", edNombreCliente.getText().toString());
            values.put("telefono", edTelefono.getText().toString());
            values.put("asunto", edAsunto.getText().toString());
            values.put("fecha", edFecha.getText().toString());
            values.put("hora", edHora.getText().toString());

// Actualizar los registros en la tabla "citas"
            int filasActualizadas = bd.update("tarea3", values, "fecha = ? and hora like ?", new String[] { fecha,"%"+hora+"%" });
            bd.close();
            if (filasActualizadas == 1)
                Toast.makeText(this, "se modificaron los datos", Toast.LENGTH_SHORT).show();
            else
                Toast.makeText(this, "no existe un cita entre las fechas", Toast.LENGTH_SHORT).show();

            //     btnaceptarconsulta.setVisibility(INVISIBLE);
        } else {
            Toast.makeText(this, "La Base de datos no existe", Toast.LENGTH_SHORT).show();
        }
        bd.close();
    }
}