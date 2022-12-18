//https://blog.baudaeletronica.com.br/controlando-led-rgb-com-resistor/
# define r 9
# define b 11
# define g 10

void setup()
{
  Serial.begin(9600);
  for(int u = 9; u < 12; u++)
  {
    pinMode(u, OUTPUT);
  }
}

int max = 255;
int sv = 0;

void loop()
{
  if (Serial.available())
  {  
    String txt = Serial.readStringUntil('\n');
    sv = txt.toInt();
    Led();
  }
}

void Led()
{
  if(sv >= 0 && sv < 255)
  {
     analogWrite(r, 255);
     analogWrite(g, sv);
     analogWrite(b, 0);
  }
  if(sv >= 255 && sv < 510)
  {
     analogWrite(r, 255 - sv / 2);
     analogWrite(g, 255);
     analogWrite(b, 0);
  }
  if(sv >= 510 && sv < 765)
  {
     analogWrite(r, 0);
     analogWrite(g, 255);
     analogWrite(b, sv / 3);
  }
  if(sv >= 765 && sv < 1020)
  {
     analogWrite(r, 0);
     analogWrite(g, 255 - sv / 4);
     analogWrite(b, 255);
  }
  if(sv >= 1020 && sv < 1275)
  {
     analogWrite(r, sv / 5);
     analogWrite(g, 0);
     analogWrite(b, 255);
  }
}
