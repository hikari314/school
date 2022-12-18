package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    TextView txtName;
    Button btnShow, btnRegister;
    ListView lstData;
    List<String> anames;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        long idSelected = getIntent().getLongExtra("ID", 0);
        long positionSelected = getIntent().getIntExtra("POSITION", 0);

        txtName = findViewById(R.id.txtName);
        btnShow = findViewById(R.id.btnShow);
        btnRegister = findViewById(R.id.btnRegister);
        lstData = findViewById(R.id.lstData);
        anames = new ArrayList<>();

        anames.add("Open W1");
        anames.add("Open W2");
        ArrayAdapter<String> adp = new ArrayAdapter<>(getBaseContext(), android.R.layout.simple_list_item_1,anames); //adapter adpta o design a lista "anames"
        lstData.setAdapter(adp);

        //segundo
        btnShow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
               /* com textview
               //mostrar todos:
                String b = "";
                for (int i = 0; i<lstnames.size(); i++)
                {
                    //acumulador:
                    b = b + lstnames.get(i) + "\n";
                }
                lblShow.setText(b);*/

                ArrayAdapter<String> adp = new ArrayAdapter<>(getBaseContext(), android.R.layout.simple_list_item_1,anames); //adapter adpta o design a lista "anames"
                lstData.setAdapter(adp); //como se fosse o show
                //para limpar:
                anames = new ArrayList<>();
            }
        });

        //primeiro
        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String a = txtName.getText().toString();
                anames.add(a);
                txtName.setText("");
            }
        });

        //para clicar no item
        lstData.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                /*Object o = lstData.getItemAtPosition(i); //posicao que a péssoa clicou
                String x = o.toString(); //guarda o texto do que foi clicado
                Toast.makeText(getBaseContext(), x, Toast.LENGTH_LONG).show(); //aqui mostra*/

                if (i == 0)
                {
                    Intent it = new Intent(getBaseContext(), W1.class);
                    startActivity(it);
                }
                if (i == 1){
                    Intent z = new Intent(getBaseContext(), W2.class);
                    startActivity(z);
                }

                //OPTION: - mas ai tira o negocio lá de cima, o Open W1 e W2
                /*Intent intent = new Intent(getApplicationContext(),W1.class);
                intent.putExtra("ID", l);
                intent.putExtra("POSITION", i);
                startActivity(intent);

                Intent b = new Intent(getApplicationContext(),W2.class);
                intent.putExtra("ID", l);
                intent.putExtra("POSITION", i);
                startActivity(b);*/
            }
        });
    }
}