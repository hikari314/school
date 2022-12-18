package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText txtNameP;
    Button btnStart;
    boolean p;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txtNameP = findViewById(R.id.txtNameP);
        btnStart = findViewById(R.id.btnStart);
        Share l1 = new Share();

        btnStart.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                p = val();
                if (p){
                    String n = txtNameP.getText().toString();
                    l1.setName(n);
                    finish();

                    Intent a = new Intent(getBaseContext(), W1.class);
                    startActivity(a);
                }
                else {
                    Toast.makeText(getBaseContext(), "Insert your name!", Toast.LENGTH_LONG).show();
                }
            }
        });
    }

    private boolean val() {

        boolean retorn = false;
        if (!TextUtils.isEmpty(txtNameP.getText().toString())){
            retorn = true;
        }else{
            txtNameP.setError("*");
            txtNameP.requestFocus();
        }
        return retorn;
    }
}