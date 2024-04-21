using Newtonsoft.Json;
using PCMIOTDF.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCMIOTDF
{
    public partial class wifiConnect : Form
    {
        string WifiTextBox;
        string PasswordTextBox;
        string ConfirmWifiTextBox; 
        string ConfirmPasswordTextBox;
        public wifiConnect()
        {
            InitializeComponent();
         

        }

        private void WifiConnect_Load(object sender, EventArgs e)
        {

        }
        public bool CheackFieldWifi(string wifi, string password, string ConfirmWifi, string  ConfirmPassword)
        {
            // Check if username and password are not empty
            if (string.IsNullOrEmpty(wifi) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Wifi and password", "Error!", MessageBoxButtons.OK);
                return false;
            }

            // Check if passwords match
            if (password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Error!", MessageBoxButtons.OK);
                return false;
            }
            if (wifi != ConfirmWifi)
            {
                MessageBox.Show("Wifi do not match", "Error!", MessageBoxButtons.OK);
                return false;
            }
            // Additional checks can be added here, such as:
            // - Minimum password length
            // - Password complexity
            // - Username validity

            // Return true if all checks are passed
            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //checks And Enter The Wifi And PassWord
            WifiTextBox = NameWifiTB.Text.Trim();
            PasswordTextBox = PasswordTB.Text.Trim();
            ConfirmWifiTextBox = ConfirmNameWifiTB.Text.Trim();
            ConfirmPasswordTextBox = ConfirmPasswordTB.Text.Trim();
            

            bool isValid = CheackFieldWifi(WifiTextBox, PasswordTextBox, ConfirmWifiTextBox, ConfirmPasswordTextBox);

            if (isValid)
            {
                // Login successful
                MessageBox.Show("Logged in successfully!");
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid credentials");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            postData postdate = new postData()
            {
                name = "Naji Alqwbai",
                address = "Thamars ",
                age = 25
            };
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            // var jsondd = JsonSerializer.
            try
            {
                var json = JsonConvert.SerializeObject(postdate); // مثال لبيانات JSON
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var respons = client.PostAsync("posts", content).Result;
               
                if (respons.IsSuccessStatusCode)
                {
                    /*var options = new JsonWriterException
                    {
                        PropertyNameCaseInsensitive = true
                    };*/
                    var responseContent = respons.Content.ReadAsStringAsync().Result;
                    var responsID = JsonConvert.DeserializeObject<PostResponsID>(responseContent);
                    //listBox1.Items.Add(responseContent);
                    listBox1.Items.Add("Id: "+responsID.id);
                }
                else
                {
                    MessageBox.Show("Error: " + respons.StatusCode);
                }
            }
            catch (Exception ex) { MessageBox.Show( ex.Message, "Error: "); }
        }
    }
}
/*Label label6 = new Label();
          Label label3 = new Label();
          Label label4 = new Label();
          Label label5 = new Label();
        TextBox NameWifiTB   = new TextBox();
        TextBox PasswoordTB  = new TextBox();
        TextBox NameWifiTB2  = new TextBox();
        TextBox PasswoordTB2 = new TextBox();
      
        public void ShowFieldWifi()
        {
            //انشاء حقول الشبكه وكلمه السر


            // label6
            // 
            
            
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label6.Location = new System.Drawing.Point(39, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name Wifi";
            // 
            // NameWifiTB
            // 
            this.NameWifiTB.Location = new System.Drawing.Point(234, 237);
            this.NameWifiTB.Multiline = true;
            NameWifiTB.Font = new Font("Tahoma", 16F);
            this.NameWifiTB.Name = "NameWifiTB";
            this.NameWifiTB.Size = new System.Drawing.Size(273, 41);
            this.NameWifiTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label3.Location = new System.Drawing.Point(39, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // PasswoordTB
            // 
            this.PasswoordTB.Location = new System.Drawing.Point(234, 299);
            this.PasswoordTB.Multiline = true;
            PasswoordTB.Font = new Font("Tahoma", 16F);
            this.PasswoordTB.Name = "PasswoordTB";
            this.PasswoordTB.Size = new System.Drawing.Size(273, 41);
            this.PasswoordTB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label5.Location = new System.Drawing.Point(39, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name Wifi";
            // 
            // NameWifiTB2
            // 
            this.NameWifiTB2.Location = new System.Drawing.Point(234, 357);
            this.NameWifiTB2.Multiline = true;
            NameWifiTB2.Font = new Font("Tahoma", 16F);
            this.NameWifiTB2.Name = "NameWifiTB2";
            this.NameWifiTB2.Size = new System.Drawing.Size(273, 41);
            this.NameWifiTB2.TabIndex = 18;
            this.NameWifiTB2.TextChanged += new System.EventHandler(this.NameWifiTB2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label4.Location = new System.Drawing.Point(39, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            
            // 
            // PasswoordTB2
            // 
            this.PasswoordTB2.Location = new System.Drawing.Point(234, 419);
            this.PasswoordTB2.Multiline = true;
            PasswoordTB2.Font = new Font("Tahoma", 16F);
            this.PasswoordTB2.Name = "PasswoordTB2";
            this.PasswoordTB2.Size = new System.Drawing.Size(273, 41);
            this.PasswoordTB2.TabIndex = 20;
           
            Control[] controlsToAdd = new Control[] { label4, label3, label5, label6, PasswoordTB2, PasswoordTB, NameWifiTB, NameWifiTB2 };
            this.Controls.AddRange(controlsToAdd);


        }
*/
