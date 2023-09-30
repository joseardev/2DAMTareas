package com.tarea2.tarea3;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class CitaDao {
    public static void bajaCitasPorFechaHora(Context context,String fecha, String hora) {
        String nombreBD = "jose";
        AdminBD admin = new AdminBD(context, nombreBD, null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String[] args = new String[]{fecha,String.valueOf(hora)};
        if (bd != null) {
            int cant = bd.delete("tarea3", "fecha=? and hora=?", args);

            bd.close();

            if (cant == 1)
                Toast.makeText(context, "Se eliminó la cita", Toast.LENGTH_SHORT).show();
            else
                Toast.makeText(context, "No existe la cita", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(context, "La Base de datos no existe", Toast.LENGTH_SHORT).show();
        }

        bd.close();
    }

}
