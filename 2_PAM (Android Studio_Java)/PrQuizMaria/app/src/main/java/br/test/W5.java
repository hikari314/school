package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

public class W5 extends AppCompatActivity {

    TextView txtQ5;
    RadioButton rdb1_5;
    RadioButton rdb2_5;
    RadioButton rdb3_5;
    RadioButton rdb4_5;
    Button btnNext5;

    int answer5;
    String ans5;
    String[] que4 = {"How long does it take light from the sun to reach the earth?",
                        "How can we tell (in principle) if we live in a universe is which space is flat or in a universe in which space is positively curved?",
                            "Which of the following theories suggests that the universe originated from a singularity that expanded continuously?"};
    String[] e0 = {"Approximately 8 minutes and 18 seconds", "Approximately 8 minutes and 15 seconds", "Approximately 5 minutes and 07 seconds", "Approximately 5 minutes and 14 seconds"};
    String[] e1 = {"Find out if the universe has boundaries", "Find out if the universe has a center", "Determine whether there is cosmic background radiation", "Measurement of the sum of the angles of a very large triangle"};
    String[] e2 = {"Oscillating Universe", "Steady State", "Big Bang", "Pulsating"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_w5);

        txtQ5 = findViewById(R.id.txtQ5);
        rdb1_5 = findViewById(R.id.rdb1_5);
        rdb2_5 = findViewById(R.id.rdb2_5);
        rdb3_5 = findViewById(R.id.rdb3_5);
        rdb4_5 = findViewById(R.id.rdb4_5);
        btnNext5 = findViewById(R.id.btnNext5);
        Share l6 = new Share();

        int ram4 = (int) (3*Math.random());
        txtQ5.setText(que4[ram4]);

        switch(ram4){
            case 0: {
                rdb1_5.setText(e0[0]);
                rdb2_5.setText(e0[1]);
                rdb3_5.setText(e0[2]);
                rdb4_5.setText(e0[3]);
                answer5 = 0;
                break;
            }

            case 1: {
                rdb1_5.setText(e1[0]);
                rdb2_5.setText(e1[1]);
                rdb3_5.setText(e1[2]);
                rdb4_5.setText(e1[3]);
                answer5 = 1;
                break;
            }

            case 2: {
                rdb1_5.setText(e2[0]);
                rdb2_5.setText(e2[1]);
                rdb3_5.setText(e2[2]);
                rdb4_5.setText(e2[3]);
                answer5 = 2;
                break;
            }
        }

        btnNext5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (answer5 == 0){
                    if (rdb1_5.isChecked()){
                        ans5 = "y";
                    }
                    else{
                        ans5 = "n";
                    }
                }

                if (answer5 == 1){
                    if (rdb2_5.isChecked()){
                        ans5 = "y";
                    }
                    else{
                        ans5 = "n";
                    }
                }

                if (answer5 == 2){
                    if (rdb3_5.isChecked()){
                        ans5 = "y";
                    }
                    else{
                        ans5 = "n";
                    }
                }

                l6.setT(ans5);
                finish();

                Intent f = new Intent(getBaseContext(), Finish.class);
                startActivity(f);
            }
        });
    }
}