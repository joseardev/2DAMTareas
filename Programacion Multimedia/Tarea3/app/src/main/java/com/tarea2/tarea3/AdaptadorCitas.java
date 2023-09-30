package com.tarea2.tarea3;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class AdaptadorCitas extends BaseAdapter {

    private Context context;
    private ArrayList<Cita> listaCita;
    private LayoutInflater inflater;

    public AdaptadorCitas(Activity context, ArrayList<Cita> listaCita) {
        this.context = context;
        this.listaCita = listaCita;
        inflater = LayoutInflater.from(context);
    }
    static class ViewHolder {
        TextView tvNombre,tvTelefono, tvAsunto,tvFecha, tvHora;
        Button btBorrarCita;
    }
    @Override
    public int getCount() {
        return listaCita.size();
    }

    @Override
    public Object getItem(int i) {
        return listaCita.get(i);
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
            //La vista no está creada, así que la crea. Cuando vuelva a //comprobar
            //si existe, reutilizará el objeto convertView para //ahorrarse la creación de un nuevo objeto.
            view = inflater.inflate(R.layout.lista, null);
            holder = new ViewHolder();
            //Creamos un objeto de la clase ViewHolder y hacemos que cada atributo //referencie
            //a un elemento del laout. Esta referencia se mantiene y //cuando reutilicemos la vista
            //convertView ya no tendrá que llamar al método findViewById()
            holder.tvNombre = (TextView) view.findViewById(R.id.tvNombre);
            holder.tvTelefono = (TextView) view.findViewById(R.id.tvTelefono);
            holder.tvAsunto = (TextView) view.findViewById(R.id.tvAsunto);
            holder.btBorrarCita = (Button) view.findViewById(R.id.btEliminar);
            holder.tvFecha = (TextView) view.findViewById(R.id.tvFecha);
            holder.tvHora = (TextView) view.findViewById(R.id.tvHora);

            Button btn = view.findViewById(R.id.btEliminar);
            btn.setTag(i); // Establecer la posición como la etiqueta del botón
            btn.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    int position = (int) view.getTag(); // Recuperar la posición del elemento
                    // Hacer algo con la posición, como mostrar un mensaje de registro
                    Toast.makeText(context, "hola 1"+position, Toast.LENGTH_SHORT).show();
                    Intent intent = new Intent(context, BorrarCitas.class);
                    intent.putExtra("posicion", position);
                    context.startActivity(intent);
                }
            });

            view.setTag(holder);
        }
        /*
         * En caso de que la View no sea null se reutilizará con los
         * nuevos valores
         */
        else {
            holder = (ViewHolder) view.getTag();
        }
        Cita cita = listaCita.get(i);
        holder.tvNombre.setText(cita.getNombreCliente());
        int telefono = cita.getTelefonoCliente();
        holder.tvTelefono.setText(telefono+"");
        holder.tvAsunto.setText(cita.getAsunto());
        holder.tvFecha.setText(cita.getFechaCita());
        holder.tvHora.setText(cita.getHora());

        return view;
    }


}
