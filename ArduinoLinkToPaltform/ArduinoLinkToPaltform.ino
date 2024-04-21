#include <SoftwareSerial.h>
#include <stdlib.h>
//#include <String.h> 
// متغيرات لتخزين اسم الشبكة وكلمة المرور
SoftwareSerial ESP8266(2, 3); // RX, TX
unsigned char check_connection = 0;
unsigned char times_check = 0;
String inputString = "";         // a string to hold incoming data
bool receivingSSID =true ;
boolean stringComplete = false; 
String ssid="";//"#WIFInajia#\n";
String password="";//"#PASSnaji123456#\n";
String commandString="";
char inChar;
boolean ArduinoInfoPort=true;
int DigitalPinCount = NUM_DIGITAL_PINS;
int AnalogPinCount = NUM_ANALOG_INPUTS;
void setup() 
  {
    Serial.begin(115200);
  }

void loop() 
  {
    
    if(stringComplete)
    {
      stringComplete=false; 
      connectToWifi(ssid,password);
    }
    if(check_connection==0)
    {
      serialEvent();
    }
    if(check_connection==1)
    {
      ArduinoInfo();
    }
  }

void initESP8266()
 { // إرسال أوامر AT الأولية إلى ESP8266
  ESP8266.begin(115200);
  ESP8266.print("***VER:");
  delay(2000);
  ESP8266.println("AT+RST");
  delay(1000);
  ESP8266.println("AT+GMR");
  delay(1000);
  ESP8266.println("AT+CWMODE=3");
  delay(1000);
  ESP8266.println("AT+CWLAP");
  delay(1000);
 }
 
void getCommand()
  {
    if(ssid.length()>0)
    {
      commandString = ssid.substring(1,5);
     
    }
  }
boolean getWifiState()
  {
    boolean state = false;
    if(check_connection==1)
    {
      state = true;
    }else
    {
      state = false;
    }
    return state;
  }
void connectToWifi(String ssid_, String password_) 
  {
    if(receivingSSID)
    {
    initESP8266();
    Serial.println("Connecting to Wifi...");
    while (check_connection == 0)
     {
      Serial.print(".");
      ESP8266.print("AT+CWJAP=\""+ssid_+"\",\""+password_+"\"\r\n");
      ESP8266.setTimeout(5000);
      if (ESP8266.find("WIFI CONNECTED\r\n") == 1)
       {
        Serial.println("WIFI CONNECTED");
        check_connection = 1;
        receivingSSID=false;
        break;
       }
      times_check++;
      if (times_check > 3)
       {
        times_check = 0;
        Serial.println("Trying to Reconnect..");
        break;
       }
    }
    }
    
  }
void serialEvent()
  {
    if(receivingSSID)
    {
     while (Serial.available())
      {
        inChar = (char)Serial.read();
        if (inChar =='\n')  {break;}
        else{inputString += inChar;}
      }
     if(inChar =='\n')
      {
        int SSIDIndexOF = inputString.indexOf("##SSID");
        int PASSIndexOF = inputString.indexOf("##PASS");
        if(SSIDIndexOF!=-1)
        {
        ssid = inputString.substring(SSIDIndexOF + 6, PASSIndexOF - 2);
        password = inputString.substring(PASSIndexOF + 6, inputString.length() - 2);
        inChar="";
        inputString="";
        stringComplete = true;
       // receivingSSID=false;
        }
         else{
          inChar="";
          }
      
      }
    }
  }


void ArduinoInfo() {
  if (ArduinoInfoPort) {
    ArduinoInfoPort=false;
    String message = "AnalogPinCount=";
    message += AnalogPinCount;
    message += "*DigitalPinCount=";
    message += DigitalPinCount;
    Serial.println(message);
  }
}
