package com.tarea2.tarea3;

import java.util.Date;

public class Cita {

    private int mumCita;

    public int getMumCita() {
        return mumCita;
    }

    public void setMumCita(int mumCita) {
        this.mumCita = mumCita;
    }

    public String getFechaCita() {
        return fechaCita;
    }

    public void setFechaCita(String fechaCita) {
        this.fechaCita = fechaCita;
    }

    public String getNombreCliente() {
        return nombreCliente;
    }

    public void setNombreCliente(String nombreCliente) {
        this.nombreCliente = nombreCliente;
    }

    public String getAsunto() {
        return Asunto;
    }

    public void setAsunto(String asunto) {
        Asunto = asunto;
    }

    public int getTelefonoCliente() {
        return telefonoCliente;
    }

    public void setTelefonoCliente(int telefonoCliente) {
        this.telefonoCliente = telefonoCliente;
    }

    public String getHecha() {
        return hecha;
    }

    public void setHecha(String hecha) {
        this.hecha = hecha;
    }

    public String getHora() {
        return hora;
    }

    public void setHora(String hora) {
        this.hora = hora;
    }

    private String fechaCita;
    private String nombreCliente;
    private String Asunto;
    private int telefonoCliente;

    private String hecha;

    private String hora;

    public Cita(int mumCita, String fechaCita, String nombreCliente, String asunto, int telefonoCliente,String hora) {
        this.mumCita = mumCita;
        this.fechaCita = fechaCita;
        this.nombreCliente = nombreCliente;
        Asunto = asunto;
        this.telefonoCliente = telefonoCliente;
        this.hora = hora;
    }





}
