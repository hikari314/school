package br.test;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

public class W1 extends AppCompatActivity {

    TextView txtQ1;
    RadioButton rdb1_1;
    RadioButton rdb2_1;
    RadioButton rdb3_1;
    RadioButton rdb4_1;
    Button btnNext;

    int answer;
    String ans;
    String[] que = {"Cosmological redshift is the results of the ________",
                        "When astronomers look at distant galaxies, what sort of motion do they see?",
                            "The surface of the earth is relative young as compared to the planets, Mercury, Venus and Mars, this youthful appearance results from ____________."};
    String[] a0 = {"Expansion of the universe", "Galaxies speeding away from you", "Supermassive black holes", "Tully-fisher relation"};
    String[] a1 = {"The Galaxies are all spinning rapidly", "The galaxies are all moving rapidly away from us", "The galaxies are all moving rapidly toward us", "Galaxies to our north are moving away from us. Those to our south are approaching"};
    String[] a2 = {"Tectonic activity is still shaping the surface of the earth", "The earth is farthest from the sun", "The fact that few major impacts ever occur on Earth", "The Earth having the largest moon of all"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_w1);

        txtQ1 = findViewById(R.id.txtQ1);
        rdb1_1 = findViewById(R.id.rdb1_1);
        rdb2_1 = findViewById(R.id.rdb2_1);
        rdb3_1 = findViewById(R.id.rdb3_1);
        rdb4_1 = findViewById(R.id.rdb4_1);
        btnNext = findViewById(R.id.btnNext);
        Share l2 = new Share();

        int ram = (int) (3*Math.random());
        txtQ1.setText(que[ram]);

        switch(ram){
            case 0: {
                rdb1_1.setText(a0[0]);
                rdb2_1.setText(a0[1]);
                rdb3_1.setText(a0[2]);
                rdb4_1.setText(a0[3]);
                answer = 0;
                break;
            }

            case 1: {
                rdb1_1.setText(a1[0]);
                rdb2_1.setText(a1[1]);
                rdb3_1.setText(a1[2]);
                rdb4_1.setText(a1[3]);
                answer = 1;
                break;
            }

            case 2: {
                rdb1_1.setText(a2[0]);
                rdb2_1.setText(a2[1]);
                rdb3_1.setText(a2[2]);
                rdb4_1.setText(a2[3]);
                answer = 2;
                break;
            }
        }

        btnNext.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (answer == 0){
                    if (rdb1_1.isChecked()){
                        ans = "y";
                    }
                    else{
                        ans = "n";
                    }
                }

                if(answer == 1){
                    if (rdb2_1.isChecked()){
                        ans = "y";
                    }
                    else {
                        ans = "n";
                    }
                }

                if (answer == 2){
                    if (rdb3_1.isChecked()){
                        ans = "y";
                    }
                    else{
                        ans = "n";
                    }
                }

                l2.setA(ans);
                finish();

                Intent b = new Intent(getBaseContext(), W2.class);
                startActivity(b);
            }
        });
    }
}