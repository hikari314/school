/* TESTE 
const int LED = 13;
void setup() {
  Serial.begin(9600);    //configura comunicação serial com 9600 bps
  pinMode(LED,OUTPUT);   //configura pino do led como saída
}
void loop() {
   if (Serial.available()) //se byte pronto para leitura
   {
    switch(Serial.read())      //verifica qual caracter recebido
    {
      case 'A':                  //caso 'A'
        digitalWrite(LED,!digitalRead(LED)); //inverte estado do LED
      break;
    }
  }
}*/

int led_R = 3; // LED Vermelho (R)
int led_G = 6; // LED Verde (G)
int led_B = 5; // LED Azul (B)

const int LED = 13;
void setup() {
  Serial.begin(9600);    //configura comunicação serial com 9600 bps
  pinMode(LED,OUTPUT);   //configura pino do led como saída
  pinMode(led_R, OUTPUT);
  pinMode(led_G, OUTPUT);
  pinMode(led_B, OUTPUT);
}
void loop() {
   if (Serial.available()) //se byte pronto para leitura
   {
      
   }
 }

if(sensorValue >= 0 && sensorValue <= 35)
  {
    Red();
  }

void Red()
{
  digitalWrite(led_R, HIGH);
  digitalWrite(led_G, LOW);
  digitalWrite(led_B, LOW);
}
  
  /*//acende laranja | amarelo + vermelho
  if(sensorValue > 36 && sensorValue <= 71)
  {
    Yellow();
    delay(10);
    Red();
    delay(10);
  }
  
  //acende amarelo | vermelho + verde
  if(sensorValue > 72 && sensorValue <= 106)
  {
    Yellow();
  }
  
  //acende verde
  if(sensorValue > 107 && sensorValue <= 141)
  {
    Green();
  }  
  
  //acende azul
  if(sensorValue > 142 && sensorValue <= 176) 
  {
    Blue();
  } 
  
  //acende anil | ciano + magenta + amarelo
  if(sensorValue > 177 && sensorValue <= 211) 
  {
    Blue();
    delay(10);
    Red();
    delay(10);
    Yellow();
    delay(10);
  } 
  
  //acende roxo | vermelho + azul
  if(sensorValue > 212 && sensorValue <= 255) 
  {
    Purple();
  } 
}
 
void Green()
{
  digitalWrite(led_R, LOW);
  digitalWrite(led_G, HIGH);
  digitalWrite(led_B, LOW);
}
 
void Blue()
{
  digitalWrite(led_R, LOW);
  digitalWrite(led_G, LOW);
  digitalWrite(led_B, HIGH);
}

void Yellow()
{
  digitalWrite(led_R, HIGH);
  delay(10);
  digitalWrite (led_G, HIGH);
  delay(10);
}

void Purple()
{
  digitalWrite(led_R, HIGH);
  delay(10);
  digitalWrite(led_B, HIGH);
  delay (10);
}*/
