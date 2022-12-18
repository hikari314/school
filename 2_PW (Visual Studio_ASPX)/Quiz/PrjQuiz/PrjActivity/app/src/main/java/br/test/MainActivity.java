package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button BtnOpen;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        BtnOpen = findViewById(R.id.BtnOpen);
        BtnOpen.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent it = new Intent(getBaseContext(),Window1.class); //mensagens são disparadas de um app pra outro com "intenções"
                //| tem virgula porque precisa de dois parametros, onde voce está e a tela voce quer abrir
                startActivity(it);
            }
        });
    }
}