using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WeatherWidget
{
    public partial class Form1 : Form
    {
        private static readonly string apiKey = "4c78917d2b9c3068294a113e7a1d11c7"; 
        private static readonly string baseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string cidade = txtCidade.Text;
            if (!string.IsNullOrEmpty(cidade))
            {
                await ObterDadosClimaticosAsync(cidade);
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome de uma cidade.");
            }
        }

        private async Task ObterDadosClimaticosAsync(string cidade)
        {
            string url = $"{baseUrl}?q={Uri.EscapeDataString(cidade)}&appid={apiKey}&units=metric&lang=pt_br";
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                string clima = json["weather"]?[0]?["description"]?.ToString() ?? "N/A";
                string temperatura = json["main"]?["temp"]?.ToString() ?? "N/A";

                lblClima.Text = $"Clima: {clima}";
                lblTemperatura.Text = $"Temperatura: {temperatura} °C";
            }
            else
            {
                string mensagemErro = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Não foi possível obter os dados climáticos. Erro: {mensagemErro}");
            }
        }

    }
}
