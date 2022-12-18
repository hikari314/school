package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Finish extends AppCompatActivity {

    TextView txtResult;
    Button btnAgain;
    double r;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_finish);

        txtResult = findViewById(R.id.txtResult);
        btnAgain = findViewById(R.id.btnAgain);
        Share n = new Share();
        r = (100/5) * n.count();

        txtResult.setText("Congrats, " + n.getName() + "! You get right " + r + "%");

        btnAgain.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent h = new Intent(getBaseContext(), MainActivity.class);
                startActivity(h);
            }
        });
    }
}