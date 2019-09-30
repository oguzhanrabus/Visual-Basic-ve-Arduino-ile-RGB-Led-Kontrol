int ledy = 9;
int ledm = 10;
int ledk = 11;
int vbbuton;
byte rastgelesayik;
byte rastgelesayiy;
byte rastgelesayim;
void setup()
{
	pinMode(ledk, OUTPUT);
	pinMode(ledy, OUTPUT);
	pinMode(ledm, OUTPUT);
	Serial.begin(9600);
}
void loop()
{
	rastgelesayik = random();
	rastgelesayik = random();
	rastgelesayiy = random();

	if (Serial.available())
	{
		delay(50);
		while (Serial.available()>0)
		{
			vbbuton = Serial.read();
			if (vbbuton=='1') //kýrmýzý
			{
				analogWrite(ledk, 255);
				analogWrite(ledy, 0);
				analogWrite(ledm, 0);
			}
			else if (vbbuton=='2') //yeþil
			{
				analogWrite(ledk, 0);
				analogWrite(ledy, 255);
				analogWrite(ledm, 0);
			}
			else if (vbbuton == '3') //mavi
			{
				analogWrite(ledk, 0);
				analogWrite(ledy, 0);
				analogWrite(ledm, 255);
			}
			else if (vbbuton == '4') //sarý
			{
				analogWrite(ledk, 255);
				analogWrite(ledy, 255);
				analogWrite(ledm, 0);
			}
			else if (vbbuton == '5') //beyaz
			{
				analogWrite(ledk, 255);
				analogWrite(ledy, 255);
				analogWrite(ledm, 255);
			}
			else if (vbbuton == '6')
			{
				analogWrite(ledk, rastgelesayik);
				analogWrite(ledy, rastgelesayiy);
				analogWrite(ledm, rastgelesayim);
			}

			else if (vbbuton == '7')
			{
				analogWrite(ledk, rastgelesayik);
				analogWrite(ledy, rastgelesayiy);
				analogWrite(ledm, rastgelesayim);
			}
			else if (vbbuton == '0')
			{
				analogWrite(ledk, 0);
				analogWrite(ledy, 0);
				analogWrite(ledm, 0);
			}
		}
	}
}
