package com.example.tarea01;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputLayout;

import java.util.Locale;
import java.util.Objects;

public class LoginActivity extends AppCompatActivity {
    Button btnRegistro;
    Button btnLogin;
    EditText edUsuario;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        setup();
    }
    private void setup(){
        //Iniciamos la variables con los campos de la activity
        EditText etUsuario = (EditText)findViewById(R.id.etUsuario);
        EditText etPassword = (EditText)findViewById(R.id.etPassword);
        btnRegistro = (Button) findViewById(R.id.btRegistro);
        btnLogin = (Button) findViewById(R.id.btLogin);

        //Registro
        btnRegistro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                //Obtenemos los datos introduccidos
                String usuario  = etUsuario.getText().toString();
                String password = etPassword.getText().toString();
                //Comprobamos que tenemos los valores usuario password
                if (usuario.length() > 0 && password.length() > 0) {
                    if(!CompruebaExisteUsuario(usuario, password)){
                        Toast.makeText(LoginActivity.this, etUsuario.getText(), Toast.LENGTH_SHORT).show();
                        //Generamos Intent
                        Intent intent = new Intent(LoginActivity.this, RegistroActivity.class);
                        //Añadimos los parammetros que queremos pasar
                        intent.putExtra("usuario",usuario);
                        intent.putExtra("password",password);
                        //iniciamos activity
                        startActivity(intent);
                    }else {
                        Toast.makeText(LoginActivity.this, R.string.user_exist, Toast.LENGTH_SHORT).show();
                    }

                }else {
                    Toast.makeText(LoginActivity.this, R.string.faltan_datos, Toast.LENGTH_SHORT).show();
                }
            }
        });
        //LOGIN
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                //Obtenemos los datos introduccidos
                String usuario  = etUsuario.getText().toString();
                String password = etPassword.getText().toString();
                //Comprobamos que tenemos los valores usuario password
                if (usuario.length() > 0 && password.length() > 0) {
                    //Comprobamos si es un usuario permitido
                    if (CompruebaUsuarioPermitido(usuario, password)) {
                        Toast.makeText(LoginActivity.this, "Bienvendido "  + usuario, Toast.LENGTH_SHORT).show();
                        //Generamos Intent
                        Intent intent = new Intent(LoginActivity.this, DespedidaActivity.class);
                        //Añadimos los parammetros que queremos pasar
                        intent.putExtra("usuario", usuario);
                        startActivity(intent);
                    }else {
                        Toast.makeText(LoginActivity.this, getString(R.string.datos_incorrectos) , Toast.LENGTH_SHORT).show();
                    }
                }else {
                    Toast.makeText(LoginActivity.this, getString(R.string.faltan_datos) , Toast.LENGTH_SHORT).show();
                }
            }
        });
    }

    //Comprueba que el usuario esta registrado
    // param
    // usuario => nombre de usuario
    // password => nombre de password
    private boolean CompruebaUsuarioPermitido(String usuario , String password){
        boolean loginStatus = false;
        if(usuario.equalsIgnoreCase("admin") && password.equalsIgnoreCase("root")){
            loginStatus = true;
        } else if (usuario.equalsIgnoreCase("user") && password.equalsIgnoreCase("1234")) {
            loginStatus = true;
        }
        return loginStatus;
    }
    //Comprueba Si existe el usuario
    // param
    // usuario => nombre de usuario
    // password => nombre de password
    private boolean CompruebaExisteUsuario(String usuario , String password){
        boolean loginStatus = false;
        if(usuario.equalsIgnoreCase("admin") ){
            loginStatus = true;
        } else if (usuario.equalsIgnoreCase("user") ) {
            loginStatus = true;
        }
        return loginStatus;
    }
}