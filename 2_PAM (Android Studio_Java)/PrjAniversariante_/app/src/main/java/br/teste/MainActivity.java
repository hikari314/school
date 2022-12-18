package br.teste;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.github.rtoshiro.util.format.SimpleMaskFormatter;
import com.github.rtoshiro.util.format.text.MaskTextWatcher;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.concurrent.TimeUnit;

public class MainActivity extends AppCompatActivity {
    TextView txtNome, txtData;
    Button btnCadastrar, btnMostrar, btnPrxNivers;
    ListView lstNivers;

    List<String> lstNome, lstPrxNiver, lstAniver;
    List<Integer> lstIdade, lstDias;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtNome = findViewById(R.id.txtNome);
        txtData = findViewById(R.id.txtData);
        btnCadastrar = findViewById(R.id.btnCadastrar);
        btnMostrar = findViewById(R.id.btnMostrar);
        btnPrxNivers = findViewById(R.id.btnPrxNivers);
        lstNivers = findViewById(R.id.lstNivers);

        lstNome = new ArrayList<String>();
        lstIdade = new ArrayList<Integer>();
        lstPrxNiver = new ArrayList<String>();
        lstDias = new ArrayList<Integer>();

        //Criando máscara para o campo data ***OBS: Ocorreu uma implementação de biblioteca no gradle
        SimpleMaskFormatter smf = new SimpleMaskFormatter("NN/NN/NNNN"); //Formato da máscara - N é predefinido pelo github
        MaskTextWatcher mtw = new MaskTextWatcher(txtData, smf); //Relacionando o campo com a variável
        txtData.addTextChangedListener(mtw); //Referencia dizendo que o campo tem máscara

        btnCadastrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Pega o nome e adiciona no arraylist
                lstNome.add(txtNome.getText().toString());
                txtNome.setText("");

                //Atribui a data para uma variável
                String data = txtData.getText().toString();

                //Separa a data em dia/mes/ano
                String[] date = data.split("/");
                int diaData = Integer.valueOf(date[0]);
                int mesData = Integer.valueOf(date[1]);
                int anoData = Integer.valueOf(date[2]);

                //Pega a data de hoje, formata ela, transforma em string e separa
                Date today = new Date();
                SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
                String day = sdf.format(today);
                String[] hoje = day.split("/");
                int diaAtual = Integer.valueOf(hoje[0]);
                int mesAtual = Integer.valueOf(hoje[1]);
                int anoAtual = Integer.valueOf(hoje[2]);

                //Estrutura para saber qual data é maior
                if (mesAtual > mesData){
                    //Calula a idade
                    int idade = (anoAtual - anoData) + 1;
                    lstIdade.add(idade);
                    txtData.setText("");

                    //Calcula o próximo aniversário
                    int prxAno = anoAtual + 1;
                    String prx = diaData + "/" + mesData + "/" + prxAno;
                    lstPrxNiver.add(prx);

                    //Calcula a quantidade de dias
                    try {
                        Date prxNiver = sdf.parse(prx);
                        long diff = prxNiver.getTime() - today.getTime();
                        int dias = (int) (diff /(1000 * 60 * 60 * 24));
                        lstDias.add(dias);

                    } catch (ParseException e) {
                        e.printStackTrace();
                    }
                }
                else if (mesAtual == mesData && diaAtual >= diaData ){
                    //Calula a idade
                    int idade = (anoAtual - anoData) + 1;
                    lstIdade.add(idade);
                    txtData.setText("");

                    //Calcula o próximo aniversário
                    int prxAno = anoAtual + 1;
                    String prx = diaData + "/" + mesData + "/" + prxAno;
                    lstPrxNiver.add(prx);

                    //Calcula a quantidade de dias
                    try {
                        Date prxNiver = sdf.parse(prx);
                        long diff = prxNiver.getTime() - today.getTime();
                        int dias = (int) (diff /(1000 * 60 * 60 * 24));
                        lstDias.add(dias);

                    } catch (ParseException e) {
                        e.printStackTrace();
                    }
                }
                else {
                    //Calula a idade
                    int idade = (anoAtual - anoData);
                    lstIdade.add(idade);
                    txtData.setText("");

                    //Calcula o próximo aniversário
                    int prxAno = anoAtual;
                    String prx = diaData + "/" + mesData + "/" + anoAtual;
                    lstPrxNiver.add(prx);

                    //Calcula a quantidade de dias
                    try {
                        Date prxNiver = sdf.parse(prx);
                        long diff = prxNiver.getTime() - today.getTime();
                        int dias = (int) (diff /(1000 * 60 * 60 * 24));
                        lstDias.add(dias);

                    } catch (ParseException e) {
                        e.printStackTrace();
                    }
                }
            }
        });

        btnMostrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                lstAniver = new ArrayList<String>();

                for(int i = 0; i < lstNome.size(); i++){
                    lstAniver.add(lstNome.get(i) + " irá fazer: " + lstIdade.get(i) + " anos no dia: " + lstPrxNiver.get(i) + " e faltam: " + lstDias.get(i) + " dias");
                    ArrayAdapter<String> adp = new ArrayAdapter<>(getBaseContext(), android.R.layout.simple_list_item_1, lstAniver);
                    lstNivers.setAdapter(adp);
                }
            }
        });

        btnPrxNivers.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                lstAniver = new ArrayList<String>();

                for (int i = 0; i < lstNome.size(); i++){
                    if (lstDias.get(i) <= 30){
                        lstAniver.add(lstNome.get(i) + " irá fazer: " + lstIdade.get(i) + " anos no dia: " + lstPrxNiver.get(i) + " e faltam: " + lstDias.get(i) + " dias");
                        ArrayAdapter<String> adp = new ArrayAdapter<>(getBaseContext(), android.R.layout.simple_list_item_1, lstAniver);
                        lstNivers.setAdapter(adp);
                    }
                }
            }
        });
    }
}