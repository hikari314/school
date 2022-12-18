package com.example.prjbingoandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    Button btnSorteio;
    Button btnMostrar;
    TextView txtMostrar;
    TextView txtSorte1;
    TextView txtSorte2;

    public static final int MAX = 75;
    static int []sorteados = new int[MAX];
    int amz;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnSorteio = findViewById(R.id.btnSorteio);
        btnMostrar = findViewById(R.id.btnMostrar);
        txtMostrar = findViewById(R.id.txtMostrar);
        txtSorte1 = findViewById(R.id.txtSorte1);
        txtSorte2 = findViewById(R.id.txtSorte2);

        btnSorteio.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                int count = 0;

                while(count<MAX){
                    int rd = (int)(MAX*Math.random()) + 1;
                    boolean achou = false;

                    for (int i=0; i<sorteados.length;i++) {
                        if (rd == sorteados[i]) {
                            achou = true;
                        }
                    }
                        if (!achou){
                            sorteados[count] = rd;
                            count++;
                        }
                }
                for (int i =0; i<sorteados.length;i++){
                    txtMostrar.setText(txtMostrar.getText() + "," + sorteados[i]);

                }
            }
        });
        btnMostrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (amz<MAX){
                    txtSorte1.setText(sorteados[amz]+"");
                    amz++;
                    txtSorte2.setText(txtSorte2.getText() + "," + txtSorte1.getText());
                }
                else{
                    txtSorte1.setText("BINGO");
                }
            }
        });
    }
}