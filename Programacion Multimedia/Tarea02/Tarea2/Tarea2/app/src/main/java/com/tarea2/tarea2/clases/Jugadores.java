package com.tarea2.tarea2.clases;

import android.graphics.drawable.Drawable;

import java.util.HashMap;
import java.util.Map;

public class Jugadores {
    private String nombre;
    private String edad;
    private String numero;
    private int logo;

    public Jugadores(String nombre, String edad, String numero, int logo) {
        this.nombre = nombre;
        this.edad = edad;
        this.numero = numero;
        this.logo = logo;
    }
    public String getNombre() {
        return nombre;
    }

    public String getEdad() {
        return edad;
    }

    public String getNumero() {
        return numero;
    }

    public int getLogo() {return logo;}

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setEdad(String edad) {
        this.edad = edad;
    }

    public void setNumero(String numero) {
        this.numero = numero;
    }

    public void setLogo(int logo) {
        this.logo = logo;
    }




}
