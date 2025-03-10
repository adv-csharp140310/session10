using System.Net;
using System.Text.Json;
using System.Threading;
using RestClient.Model;
using RestSharp;


namespace RestClient
{
    public partial class Form1 : Form
    {

        RestSharp.RestClient client = new RestSharp.RestClient(
                new RestClientOptions
                {
                    BaseUrl = new Uri("https://jsonplaceholder.typicode.com/")
                });

        public Form1()
        {
            InitializeComponent();
        }



        private void buttonWebClient_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();
            var data = webClient.DownloadString(new Uri("https://jsonplaceholder.typicode.com/users"));
            MessageBox.Show(data);
        }

        //https://restsharp.dev/
        //dotnet add package RestSharp
        private async void buttonRestSharp_Click(object sender, EventArgs e)
        {
            //user
            var request = new RestRequest("users");
            var response = await client.GetAsync(request);
            var json = response.Content;

            var users = JsonSerializer.Deserialize<List<User>>(json);            

            dataGridView1.DataSource = users;
        }

        

        //https://github.com/reactiveui/refit
    }
}
