package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.Toast;

public class Window1 extends AppCompatActivity {

    Share sh = new Share();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_window1);

        //sh.setText("10"); aqui vale o valor que voce colocou por ultimo, então vale esse
        String x = sh.getText();
        Toast.makeText(getBaseContext(), x, Toast.LENGTH_LONG).show(); //para mostrar
    }
}