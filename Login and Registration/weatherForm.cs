using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Login_and_Registration
{
    public partial class weatherForm : Form
    {
        public weatherForm()
        {
            InitializeComponent();
        }

        string apiKey = ""; //your api key from OpenWeather

        private bool mouseDown;
        private Point lastLocation;

        void getWeather()
        {
            using (WebClient client = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", searchCityTextbox.Text, apiKey);
                var json = client.DownloadString(url);
                WeatherInfo.sum Info = JsonConvert.DeserializeObject<WeatherInfo.sum>(json);

                ConditionLabel.Text = Info.weather[0].main;
                DetailsLabel.Text = Info.weather[0].description;
                SunriseLabel.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                SunsetLabel.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                TemperatureLabel.Text = Info.main.temp.ToString();
                WindLabel.Text = Info.wind.speed.ToString();
                PressureLabel.Text = Info.main.pressure.ToString();
            }
        }

        DateTime convertDateTime(long seconds)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            dateTime = dateTime.AddSeconds(seconds).ToLocalTime();
            return dateTime;
        }

        private void searchCityTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getWeather();
                convertKelvinToCelcius();
                weatherPanel.Visible = true;
            }
        }

        private void convertKelvinToCelcius()
        {
            double kelvin = double.Parse(TemperatureLabel.Text);
            double celcius;
            celcius = kelvin - 273.15;
            TemperatureLabel.Text = Math.Ceiling(celcius).ToString();
        }

        private void weatherForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void weatherForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void weatherForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
