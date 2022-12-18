package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    Share sh = new Share(); //sh é um objeto
    //new Share é um método chamado de método construtor -> não precisava criar porque já existia
    //aqui vai nascer com cinco => Share sh = new Share(5);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);//mande carrefar o xml

        sh.setText("5"); //passar depois do que criar com 5 -> aqui dá pau pq porque é String = sh.setText(5); | guarde 5
        //abrir a tela sem botão: | mande abrir a outra tela
        Intent it = new Intent(getBaseContext(), Window1.class);
        startActivity(it);
    }
}