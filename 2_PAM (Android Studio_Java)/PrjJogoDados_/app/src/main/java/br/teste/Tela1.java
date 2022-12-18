package br.teste;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class Tela1 extends AppCompatActivity {

    TextView lblMsg;
    Compartilha cp = new Compartilha();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela1);
        lblMsg = findViewById(R.id.lblMsg);
        String x = cp.getInfo();//pegou info
        lblMsg.setText(x);
    }
}