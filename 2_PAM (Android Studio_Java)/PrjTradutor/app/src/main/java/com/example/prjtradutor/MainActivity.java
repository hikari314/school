package com.example.prjtradutor;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    EditText editTxtE;
    TextView txtResult;
    ImageButton imgBtn;
    String[] a = {"unha", "cabelo", "brinco"};
    String[] b = {"nail", "hair", "earing"};
    int p ;
    String k;
    int po;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editTxtE = findViewById(R.id.editTxtE);
        txtResult = findViewById(R.id.txtResult);
        imgBtn = findViewById(R.id.imgBtn);

        imgBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                k = editTxtE.getText().toString();

                for (p = 0; p < a.length; p = p + 1){
                    if (k.equals(a[p])){
                        po = p;
                        txtResult.setText(b[po]);
                        break;
                    }
                    else{
                        txtResult.setText("No results found!");
                    }
                }
            }
        });
    }
}