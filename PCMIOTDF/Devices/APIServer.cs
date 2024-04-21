using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PCMIOTDF.Devices
{
    class APIServer
    {
        HttpClient client=new HttpClient();

        void Update()
        {
           /*  var httpClient = new HttpClient();

            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            //var json = JsonConvert.SerializeObject();
            string jsonData = JsonConvert.SerializeObject(arduinoAPI); // مثال لبيانات JSON
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage messge = await client.PostAsync("api/Arduino", content);
            if (messge.IsSuccessStatusCode)
            {

            }*/

        }
      public async void LoadDataAPI()
        {
            client.BaseAddress = new Uri("Name Web site/");// اسم الموقع او الاستضافه
                // هنا نجلب البيانات من قاعده البيانات من الاستضافه 
            HttpResponseMessage respons =await client.GetAsync("api/ArduinoTable");
            //respons.
            if (respons.IsSuccessStatusCode)
            {
              //var dataFromWeb =await respons.Content.ReadFromJsonAsync<IEnumerable<ArduinoAPI>>();
            }
            

        }
        public async void PostDataToPlatform()
        {
            try
            {
                ArduinoAPI arduinoAPI = new ArduinoAPI();
                arduinoAPI.ArduinoType = "";
                arduinoAPI.WifiName = "";
                arduinoAPI.PasswordWifi = "";

                arduinoAPI.AnalogPinCount = 5;
                arduinoAPI.DgitalPinCount = 5;
                arduinoAPI.APIkeyArduino = "";
                string jsonData = JsonConvert.SerializeObject(arduinoAPI); // مثال لبيانات JSON
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage messge =await client.PostAsync("api/Arduino", content);
                if (messge.IsSuccessStatusCode)
                {
                    
                }
            }
            catch (Exception ex)
            {
            }

        }

    }
}
