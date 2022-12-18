int pushButton = 2; //botão no pino 2 - variavel

void setup() {
  Serial.begin(9600); //Serial = classe | o ponto é pra chamar os metodos e propriedades | begin é método = inicie a serial | 9600 = baud rate (velocidade de transmissão de bits) por segundo
  pinMode(pushButton, INPUT); //INPUT é constante porque tá em letra maisucula
}

void loop() {
  int buttonState = digitalRead(pushButton); //guarda na variavel o estado do botão | guarda no buttonState o valor de 0 ou 1 | 
  Serial.println(buttonState); //imprima (estado do botão) e pule a linha (ln - new line) 
  delay(1); //delay de 1 | ai se o botão tiver sendo apertado, imprime 1, se não, imprime 0
}
