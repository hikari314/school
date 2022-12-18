package br.teste;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {

    ImageView img1;
    Button btnSortear;
    Compartilha cp = new Compartilha();
    MinhaClasse abacaxi = new MinhaClasse();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        img1 = findViewById(R.id.img1);

        //abacaxi.valor = "ETESP"; //atribuição
        abacaxi.setValor("ETESP"); //fez com método
       // String x = abacaxi.valor; //declaração
        String x = abacaxi.getValor();

        btnSortear = findViewById(R.id.btnSortear);
        btnSortear.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int aNumber = (int) (6 * Math.random()) + 1;
                if(aNumber == 1){
                    img1.setImageResource(R.drawable.dado1);
                }
                if(aNumber == 2){
                    img1.setImageResource(R.drawable.dado2);
                }
                if(aNumber == 3){
                    img1.setImageResource(R.drawable.dado3);
                }
                if(aNumber == 4){
                    img1.setImageResource(R.drawable.dado4);
                }
                if(aNumber == 5){
                    img1.setImageResource(R.drawable.dado5);
                }
                if(aNumber == 6){
                    img1.setImageResource(R.drawable.dado6);
                }
                cp.setInfo(aNumber+""); //objeto/metodo(conversão p string) // guardou info
                Intent it = new Intent(getBaseContext(),Tela1.class);//classe letra maiuscula/ objeto = new método construtor (contexto~onde eu to,classe
                startActivity(it);
            }
        });
    }
}