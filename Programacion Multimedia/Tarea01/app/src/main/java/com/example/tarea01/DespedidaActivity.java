package com.example.tarea01;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

import java.util.Objects;

public class DespedidaActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_despedida);
        Objects.requireNonNull(getSupportActionBar()).setDisplayHomeAsUpEnabled(true);
        Intent intent = getIntent();
        String usuario = intent.getStringExtra("usuario");
        String email = intent.getStringExtra("email");

        TextView tbUsuario = findViewById(R.id.tvNombre);
        TextView tvMail = findViewById(R.id.tvMail);

        tbUsuario.setText("Bienvenido " +usuario);
        if (email != null){
            tvMail.setText("Email: "+ email);
        }



    }
}