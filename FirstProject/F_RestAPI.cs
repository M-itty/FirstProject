using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft;
using ClassLibrary;
using Newtonsoft.Json;

namespace FirstProject
{
    public partial class F_RestAPI : Form
    {
        public F_RestAPI()
        {
            InitializeComponent();
        }

        // Global variable
        EmpConnection.Rootobject result; // Store result of the API conversion

        private void BT_ReadAPI_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            // Call API
            // Uses RestSharp
            // Source : https://dummy.restapiexample.com/api/v1/employees

            var client = new RestClient("https://dummy.restapiexample.com/api/v1/");
            var request = new RestRequest("employees"); // Last bit of the address
            var response = client.Execute(request); // Request is rdy to go

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // rawResponse will have all data
                string rawResponse = response.Content;

                // Convert the raw data
                result = JsonConvert.DeserializeObject<EmpConnection.Rootobject>(rawResponse);

                if (result != null)
                {
                    foreach (var obj in result.data) // Put data into listbox
                    {
                        LB_Data.Items.Add(obj.employee_name);
                    }
                }

            }
        }
    }
}
