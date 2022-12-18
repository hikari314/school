package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

public class W2 extends AppCompatActivity {

    TextView txtQ2;
    RadioButton rdb1_2;
    RadioButton rdb2_2;
    RadioButton rdb3_2;
    RadioButton rdb4_2;
    Button btnNext2;

    int answer2;
    String ans2;
    String[] que1 = {"The hypothesis that pulsars were spinning was excluded because __________.",
                        "Which of the following is NOT one of Kepler's three laws?",
                            "The cosmic microwave background radiation comes from _______."};
    String[] b0 = {"Pulsars spin too fast", "White dwarfs emit x-ray", "White dwarfs have broad absorption lines", "Pulsars always have red giant companions"};
    String[] b1 = {"The shapes of the planetary orbits are ellipse", "Objects of different masses fall at the same rate", "Planets sweep out equal areas in equal times", "The square of the period of a planet's orbit equals the cube of its semi-major axis"};
    String[] b2 = {"Quasars", "Radio galaxies", "Big Bang", "Solar nebula"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_w2);

        txtQ2 = findViewById(R.id.txtQ2);
        rdb1_2 = findViewById(R.id.rdb1_2);
        rdb2_2 = findViewById(R.id.rdb2_2);
        rdb3_2 = findViewById(R.id.rdb3_2);
        rdb4_2 = findViewById(R.id.rdb4_2);
        btnNext2 = findViewById(R.id.btnNext2);
        Share l3 = new Share();

        int ram1 = (int) (3*Math.random());
        txtQ2.setText(que1[ram1]);

        switch(ram1){
            case 0: {
                rdb1_2.setText(b0[0]);
                rdb2_2.setText(b0[1]);
                rdb3_2.setText(b0[2]);
                rdb4_2.setText(b0[3]);
                answer2 = 0;
                break;
            }

            case 1: {
                rdb1_2.setText(b1[0]);
                rdb2_2.setText(b1[1]);
                rdb3_2.setText(b1[2]);
                rdb4_2.setText(b1[3]);
                answer2 = 1;
                break;
            }

            case 2: {
                rdb1_2.setText(b2[0]);
                rdb2_2.setText(b2[1]);
                rdb3_2.setText(b2[2]);
                rdb4_2.setText(b2[3]);
                answer2 = 2;
                break;
            }
        }

        btnNext2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (answer2 == 0){
                    if (rdb1_2.isChecked()){
                        ans2 = "y";
                    }
                    else{
                        ans2 = "n";
                    }
                }

                if(answer2 == 1){
                    if (rdb2_2.isChecked()){
                        ans2 = "y";
                    }
                    else {
                        ans2 = "n";
                    }
                }

                if (answer2 == 2){
                    if (rdb3_2.isChecked()){
                        ans2 = "y";
                    }
                    else{
                        ans2 = "n";
                    }
                }

                l3.setS(ans2);
                finish();

                Intent c = new Intent(getBaseContext(), W3.class);
                startActivity(c);
            }
        });
    }
}