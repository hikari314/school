package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

public class W3 extends AppCompatActivity {

    TextView txtQ3;
    RadioButton rdb1_3;
    RadioButton rdb2_3;
    RadioButton rdb3_3;
    RadioButton rdb4_3;
    Button btnNext3;

    int answer3;
    String ans3;
    String[] que2 = {"Modern cosmology supposes that the universe came from a Big Bang event about 13 billion years ago. Evidence for this is __________.",
                        "Which mineral can scratch a piece of glass?",
                            "Evidence that the universe contains much unobserved dark matter is the _________."};
    String[] c0 = {"Cosmic background radiation", "Excessive amount of gas found in the galaxy", "Uniformity of the abundance of hydrogen and helium", "Hubble expansion"};
    String[] c1 = {"Fluorite", "Feldspar", "Gypsum", "Talc"};
    String[] c2 = {"Excessive amount of dark dust in spiral galaxies", "Powerful radio emission from the center of spirals", "Flat rotation curves of spiral galaxies", "Excessive amount of gas found in spiral galaxies"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_w3);

        txtQ3 = findViewById(R.id.txtQ3);
        rdb1_3 = findViewById(R.id.rdb1_3);
        rdb2_3 = findViewById(R.id.rdb2_3);
        rdb3_3 = findViewById(R.id.rdb3_3);
        rdb4_3 = findViewById(R.id.rdb4_3);
        btnNext3 = findViewById(R.id.btnNext3);
        Share l4 = new Share();

        int ram2 = (int) (3*Math.random());
        txtQ3.setText(que2[ram2]);

        switch(ram2){
            case 0: {
                rdb1_3.setText(c0[0]);
                rdb2_3.setText(c0[1]);
                rdb3_3.setText(c0[2]);
                rdb4_3.setText(c0[3]);
                answer3 = 0;
                break;
            }

            case 1: {
                rdb1_3.setText(c1[0]);
                rdb2_3.setText(c1[1]);
                rdb3_3.setText(c1[2]);
                rdb4_3.setText(c1[3]);
                answer3 = 1;
                break;
            }

            case 2: {
                rdb1_3.setText(c2[0]);
                rdb2_3.setText(c2[1]);
                rdb3_3.setText(c2[2]);
                rdb4_3.setText(c2[3]);
                answer3 = 2;
                break;
            }
        }

        btnNext3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (answer3 == 0){
                    if (rdb1_3.isChecked()){
                        ans3 = "y";
                    }
                    else{
                        ans3 = "n";
                    }
                }

                if(answer3 == 1){
                    if (rdb2_3.isChecked()){
                        ans3 = "y";
                    }
                    else {
                        ans3 = "n";
                    }
                }

                if (answer3 == 2){
                    if (rdb3_3.isChecked()){
                        ans3 = "y";
                    }
                    else{
                        ans3 = "n";
                    }
                }

                l4.setP(ans3);
                finish();

                Intent d = new Intent(getBaseContext(), W4.class);
                startActivity(d);
            }
        });
    }
}