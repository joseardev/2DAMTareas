package com.tarea2.tarea2.clases;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.tarea2.tarea2.MainActivity;
import com.tarea2.tarea2.R;

import java.util.ArrayList;

public class AdaptadorJugadores extends BaseAdapter {

    private Context context;
    private ArrayList<Jugadores> listaJugadores;
    private LayoutInflater inflater;

    public AdaptadorJugadores(Activity context, ArrayList<Jugadores> listaJugadores) {
       //Inicializamos las variable
        this.context = context;
        this.listaJugadores = listaJugadores;
        inflater = LayoutInflater.from(context);
    }
    static class ViewHolder {
        TextView nombreApellidos;
        TextView edad;
        TextView numero;

        ImageView logo;
    }
    @Override
    public int getCount() {
        return listaJugadores.size();
    }

    @Override
    public Object getItem(int i) {
        return listaJugadores.get(i);
    }

    @Override
    public long getItemId(int i) {
        return i;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        ViewHolder holder = null;
            // Si la View es null se crea de nuevo
        if (view == null) {
            //La vista no está creada, así que la crea.
            //si existe, reutilizará el objeto convertView para
            // ahorrarse la creación de un nuevo objeto.
            view = inflater.inflate(R.layout.lista, null);
            holder = new ViewHolder();
            //Creamos un objeto de la clase ViewHolder y hacemos que cada atributo //referencie
            //a un elemento del laout. Esta referencia se mantiene y //cuando reutilicemos la vista
            //convertView ya no tendrá que llamar al método findViewById()
            holder.nombreApellidos = (TextView) view.findViewById(R.id.tvNombreApellidos);
            holder.edad = (TextView) view.findViewById(R.id.tvEdad);
            holder.numero = (TextView) view.findViewById(R.id.tvNumero);
            holder.logo = (ImageView) view.findViewById(R.id.ivLogo);
            view.setTag(holder);
        }
        /*
         * En caso de que la View no sea null se reutilizará con los
         * nuevos valores
         */
        else {
            holder = (ViewHolder) view.getTag();
        }
        //Obtenemos el jugador según su posicion en la lista
        Jugadores empleado = listaJugadores.get(i);
        //cargamos la lista
        holder.nombreApellidos.setText(empleado.getNombre());
        holder.edad.setText(empleado.getEdad());
        holder.numero.setText(empleado.getNumero());
        holder.logo.setImageResource(empleado.getLogo());

        return view;
    }
}
