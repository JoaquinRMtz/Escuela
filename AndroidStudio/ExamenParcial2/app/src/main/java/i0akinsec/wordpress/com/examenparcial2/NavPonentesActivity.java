package i0akinsec.wordpress.com.examenparcial2;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.LinkedList;

public class NavPonentesActivity extends AppCompatActivity {

    private TextView contenedorPonentes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nav_ponentes);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        this.contenedorPonentes = (TextView) findViewById(R.id.contenedorPonentes);

        LinkedList<Ponente> ponentesRegistrados = DatosPonentes.getPonentesRegistrados();
        StringBuilder builder = new StringBuilder();
        int cont = 1;
        if (ponentesRegistrados.size()>0)
            for (Ponente ponente : ponentesRegistrados){
                builder.append("Numero: " + cont + "\n" + ponente).append("\n\n");
                cont ++;
            }
        else
            builder.append("No hay ponentes registrados!");
        this.contenedorPonentes.setText(builder.toString());
    }

}
