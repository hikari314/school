package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

public class W4 extends AppCompatActivity {

    TextView txtQ4;
    RadioButton rdb1_4;
    RadioButton rdb2_4;
    RadioButton rdb3_4;
    RadioButton rdb4_4;
    Button btnNext4;

    int answer4;
    String ans4;
    String[] que3 = {"How old is the earth?",
                        "What powers the sun?",
                             "How far is the moon from the earth? (consider the range depending on the Moon's orbit)"};
    String[] d0 = {"4.5 billion years old", "5 billion years old", "3.6 billion years old", "2.8 billion years old"};
    String[] d1 = {"Fission, the same as a hydrogen bomb", "Fusion, the same as a hydrogen bomb", "Fusion, the same as a helium bomb", "Neutrons produced by the fusion"};
    String[] d2 = {"Ranges from about 181,000 to 260, 000 kilometers", "Ranges from about 628,000 to 720, 000 kilometers", "Ranges from about 360,000 to 405, 000 kilometers", "Ranges from about 370,000 kilometers to 500,200 kilometers"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_w4);

        txtQ4 = findViewById(R.id.txtQ4);
        rdb1_4 = findViewById(R.id.rdb1_4);
        rdb2_4 = findViewById(R.id.rdb2_4);
        rdb3_4 = findViewById(R.id.rdb3_4);
        rdb4_4 = findViewById(R.id.rdb4_4);
        btnNext4 = findViewById(R.id.btnNext4);
        Share l5 = new Share();

        int ram3 = (int) (3*Math.random());
        txtQ4.setText(que3[ram3]);

        switch(ram3){
            case 0: {
                rdb1_4.setText(d0[0]);
                rdb2_4.setText(d0[1]);
                rdb3_4.setText(d0[2]);
                rdb4_4.setText(d0[3]);
                answer4 = 0;
                break;
            }

            case 1: {
                rdb1_4.setText(d1[0]);
                rdb2_4.setText(d1[1]);
                rdb3_4.setText(d1[2]);
                rdb4_4.setText(d1[3]);
                answer4 = 1;
                break;
            }

            case 2: {
                rdb1_4.setText(d2[0]);
                rdb2_4.setText(d2[1]);
                rdb3_4.setText(d2[2]);
                rdb4_4.setText(d2[3]);
                answer4 = 2;
                break;
            }
        }

        btnNext4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (answer4 == 0){
                    if (rdb1_4.isChecked()){
                        ans4 = "y";
                    }
                    else{
                        ans4 = "n";
                    }
                }

                if (answer4 == 1){
                    if (rdb2_4.isChecked()){
                        ans4 = "y";
                    }
                    else{
                        ans4 = "n";
                    }
                }

                if (answer4 == 2){
                    if (rdb3_4.isChecked()){
                        ans4 = "y";
                    }
                    else{
                        ans4 = "n";
                    }
                }

                l5.setE(ans4);
                finish();

                Intent e = new Intent(getBaseContext(), W5.class);
                startActivity(e);
            }
        });
    }
}