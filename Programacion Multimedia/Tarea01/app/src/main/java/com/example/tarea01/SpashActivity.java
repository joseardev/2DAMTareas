package com.example.tarea01;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Objects;
import java.util.Timer;
import java.util.TimerTask;

//Genera el spashActivity
public class SpashActivity extends AppCompatActivity {
    private static final long DURACION_SPLASH = 3000;
    Timer timer = new Timer();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_spash);
        //Quitamos action bar
        Objects.requireNonNull(getSupportActionBar()).hide();
        Setup();
    }
    private void Setup() {
        //Timer => Al finalizar lanza la activity siguiente
        //DURACION_SPLASH => Duración del timer
        TimerTask task = new TimerTask() {
            public void run() {
                //llamamos activity siguiente
                Intent intent = new Intent(SpashActivity.this, LoginActivity.class);
                startActivity(intent);
                finish();
            }
        };
        //Lanza Timer
        timer.schedule(task, DURACION_SPLASH);


        Button btnSaltar = (Button) findViewById(R.id.btSaltarSpash);
        // Si se presiona el botón, se cancela el temporizador y se inicia la actividad principal
        btnSaltar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Cancelamos hilo
                timer.cancel();
                //llamamos activity siguiente
                Intent intent = new Intent(SpashActivity.this, LoginActivity.class);
                startActivity(intent);
                finish();
            }
        });
    }
}