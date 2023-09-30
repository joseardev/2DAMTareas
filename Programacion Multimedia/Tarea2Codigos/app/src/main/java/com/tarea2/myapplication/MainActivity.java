package com.tarea2.myapplication;

import android.content.DialogInterface;
import android.content.pm.ActivityInfo;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import androidx.activity.result.ActivityResultLauncher;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.journeyapps.barcodescanner.ScanContract;
import com.journeyapps.barcodescanner.ScanOptions;

import java.util.ArrayList;
import java.util.Objects;

public class MainActivity extends AppCompatActivity {
    Button btEscaner,btScannerQr, btLimpiarLista;

    private static final String TextoLectura = "Escanea el codigo";
    private ListView lvLecturas;
    private ArrayAdapter<String> adapter;
    private ArrayList<String> ltInventario;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //Bloqueamos la retoración
        setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_PORTRAIT);
        Objects.requireNonNull(getSupportActionBar()).setTitle("Inventario");
        Setup(savedInstanceState);
    }

    //Obtenemos el parametro savedInstanceState para obtener el estado de la lista al girar el movil.
    private void Setup(Bundle savedInstanceState){

        lvLecturas = findViewById(R.id.lvLecturas);
        ltInventario = new ArrayList<>();

        // Inicializar el adaptador de la lista
        adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, ltInventario);

        // Establecer el adaptador de la lista
        lvLecturas.setAdapter(adapter);

        // Restaurar el estado de la lista si existe un estado guardado
        // Esto sobretodo es si permitimos girar la aplicación
        if (savedInstanceState != null) {
            ArrayList<String> savedList = savedInstanceState.getStringArrayList("ltInventario");
            if (savedList != null) {
                ltInventario.clear();
                ltInventario.addAll(savedList);
                adapter.notifyDataSetChanged();
            }
        }

        SetupButton();

    }
    //Inicializar botones
    private void  SetupButton(){
        ScanOptions options = new ScanOptions();
        //Mensaje camara
        options.setPrompt(TextoLectura);
        //Sonido de lectura
        options.setBeepEnabled(true);
        //Permite almacenar la lectura como imagen
        options.setBarcodeImageEnabled(true);
        //Bloqueamos la orientacion
        options.setOrientationLocked(true);
        //Lectura todos los codigos
        btEscaner = findViewById(R.id.btScanner);
        btEscaner.setOnClickListener(view -> {
            //codigo activo
            options.setDesiredBarcodeFormats(ScanOptions.ALL_CODE_TYPES);
            barcodeLauncher.launch(options);
            barcodeLauncher.launch(new ScanOptions());
        });

        //Lectura codigos QR
        btScannerQr = findViewById(R.id.btQr);
        btScannerQr.setOnClickListener(view -> {
            //codigo activo
            options.setDesiredBarcodeFormats(ScanOptions.QR_CODE);
            barcodeLauncher.launch(options);
            barcodeLauncher.launch(new ScanOptions());
        });

        //Limpiar listview lecturas
        btLimpiarLista = findViewById(R.id.btLimpiarLista);
        btLimpiarLista.setOnClickListener(view -> {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.setTitle("Inventario")
                    .setMessage("Resetear Inventario?")
                    .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                        public void onClick(DialogInterface dialog, int id) {
                            //Limpiamos inventario
                            ltInventario.clear();
                            adapter.notifyDataSetChanged();
                        }

                    })
                    .setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                        public void onClick(DialogInterface dialog, int id) {
                            //Usuario cancelo
                        }
                    })
                    .show();

        });

    }
    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        // Guardar el estado de la lista
        outState.putStringArrayList("ltInventario", ltInventario);
    }
    private final ActivityResultLauncher<ScanOptions> barcodeLauncher = registerForActivityResult(new ScanContract(),
            result -> {
                if(result.getContents() == null) {
                    //El usuario cancela la lectura
                    Toast.makeText(this, "Cancelado", Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(this, "Lectura: " + result.getContents(), Toast.LENGTH_LONG).show();
                   //Añadimos lectura
                    if (!result.getContents().isEmpty()) {
                        AddLectura(result.getContents());
                    }
                }
            });

    //añadimos la lectura a la lista
    private void AddLectura(String textoLectura){

        // Comprobar si la cadena textoLectura existe en el la lista de lecturas
        if (ltInventario.contains(textoLectura)) {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.setTitle("Inventario")
                    .setMessage("Existe la referencia, añadir igualmente?")
                    .setPositiveButton("Aceptar", new DialogInterface.OnClickListener() {
                        public void onClick(DialogInterface dialog, int id) {
                            //Añadimos lectura
                            ltInventario.add(textoLectura);
                            //Notificamos el cambio para refresncar la listView
                            adapter.notifyDataSetChanged();
                        }

                    })
                    .setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                        public void onClick(DialogInterface dialog, int id) {
                            //Usuario cancelo
                        }
                    })
                    .show();
        } else {
            //Añadimos lectura
            ltInventario.add(textoLectura);
            //Notificamos el cambio para refresncar la listView
            adapter.notifyDataSetChanged();
        }
    }
}