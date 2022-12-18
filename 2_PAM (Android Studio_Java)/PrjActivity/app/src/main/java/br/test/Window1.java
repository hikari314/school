package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Window1 extends AppCompatActivity {

    Button BtnOpen2;
    Button BtnClose1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_window1);

        BtnOpen2 = findViewById(R.id.BtnOpen2);
        BtnOpen2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent it2 = new Intent(getBaseContext(),Window2.class);
                startActivity(it2);
            }
        });

        BtnClose1 = findViewById(R.id.BtnClose1);
        BtnClose1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
    }
}