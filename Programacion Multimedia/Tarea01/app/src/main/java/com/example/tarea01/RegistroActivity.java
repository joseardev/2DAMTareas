package com.example.tarea01;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import java.util.Objects;

public class RegistroActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        Intent intent = getIntent();
        String usuario = intent.getStringExtra("usuario");
        String password = intent.getStringExtra("password");


        EditText tbUsuario = findViewById(R.id.etUsuario);
        EditText tbpassword = findViewById(R.id.etPassword);
        EditText tbEmail = findViewById(R.id.etMail);
        Button btFinalizaRegistro = findViewById(R.id.btFinalizarRegistro);
        ImageView imagen = findViewById(R.id.imageView);


        tbUsuario.setText(usuario);
        tbpassword.setText(password);


        imagen.setOnClickListener(new View.OnClickListener() {
            int count = 0;
            @Override
            public void onClick(View view) {
                Drawable res = null;
               if (count == 0){
                   count = 1;
                   res = getResources().getDrawable(R.drawable.troll);
               }else {
                   count = 0;
                   res = getResources().getDrawable(R.drawable.wo);
               }

                imagen.setImageDrawable(res);
            }
        });

        btFinalizaRegistro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String usuario  = tbUsuario.getText().toString();
                String email  = tbEmail.getText().toString();
                if (tbUsuario.getText().length() > 0 && tbEmail.getText().length() > 0 && tbpassword.getText().length() > 0) {
                    Intent intent = new Intent(RegistroActivity.this, DespedidaActivity.class);
                    //Añadimos los parammetros que queremos pasar
                    intent.putExtra("usuario", usuario);
                    intent.putExtra("email", email);
                    startActivity(intent);
                    finish();
                }else {
                    Toast.makeText(RegistroActivity.this, R.string.faltan_datos, Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}