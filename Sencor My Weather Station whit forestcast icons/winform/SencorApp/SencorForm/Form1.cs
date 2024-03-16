using SencorForm.Addons;
using SencorForm.Colors;

namespace SencorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label13.Text = DateTime.Now.AddDays(1).ToString("dddd dd.MM");
            label14.Text = DateTime.Now.AddDays(2).ToString("dddd dd.MM");
            label15.Text = DateTime.Now.AddDays(3).ToString("dddd dd.MM");
            label16.Text = DateTime.Now.AddDays(4).ToString("dddd dd.MM");
            label17.Text = DateTime.Now.AddDays(5).ToString("dddd dd.MM");
        }
        bool refreshButtonisClicked = false;
        ColoriseValue colorValue = new();
        IconChanger iconChanger = new();
        PressureTendency pressureTendency = new();
        dynamic data;

        private void button1_Click(object sender, EventArgs e)
        {
            refreshButtonisClicked = true;
            using (HttpClient client = new HttpClient())
            {
                //replace url whit your awekas api key          
                string url = "https://api.awekas.at/current.php?key=UwPBC8YStcrI3hFJLqiSE%2BfWABvkjvljdsf668x0eVLcwkVCuq%2BxCDeZVyla0q5F%2ByOp9arW4ppQH880g%3D%3D&lng=en";
                try
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();
                    string json = response.Content.ReadAsStringAsync().Result;
                    data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                    if (response.IsSuccessStatusCode)
                    {
                        DayForestcast forestcastDay0 = new(data, "day0");                                // Create forestcast class for every day
                        DayForestcast forestcastDay1 = new(data, "day1");
                        DayForestcast forestcastDay2 = new(data, "day2");
                        DayForestcast forestcastDay3 = new(data, "day3");
                        DayForestcast forestcastDay4 = new(data, "day4");
                        DayForestcast forestcastDay5 = new(data, "day5");
                        RawWeatherData rawWeather = new(data);


                        day0PicBox.Image = iconChanger.ChangeIcon(forestcastDay0.IconNumber);                       // Get  icons for forestcast                             
                        day1PicBox.Image = iconChanger.ChangeIcon(forestcastDay1.IconNumber);
                        day2PicBox.Image = iconChanger.ChangeIcon(forestcastDay2.IconNumber);
                        day3PicBox.Image = iconChanger.ChangeIcon(forestcastDay3.IconNumber);
                        day4PicBox.Image = iconChanger.ChangeIcon(forestcastDay4.IconNumber);
                        day5PicBox.Image = iconChanger.ChangeIcon(forestcastDay5.IconNumber);


                        day0textBox.Text = forestcastDay0.GetWeatherData();                                  //  write text for day-forestcast
                        day1textBox.Text = forestcastDay1.GetWeatherData();
                        day2textBox.Text = forestcastDay2.GetWeatherData();
                        day3textBox.Text = forestcastDay3.GetWeatherData();
                        day4textBox.Text = forestcastDay4.GetWeatherData();
                        day5textBox.Text = forestcastDay5.GetWeatherData();


                        humidityBox.Text = rawWeather.Humidity + "%";
                        temperatureBox.Text = rawWeather.Temperature + "°C";
                        pressureBox.Text = rawWeather.AirPressure + "hPa";
                        windSpeedBox.Text = rawWeather.Windspeed + "km/h";
                        rainPrecipBox.Text = rawWeather.Precipitation + "L/m²";
                        solarRadiationBox.Text = rawWeather.SolarRadiation + "W/m²";
                        windGustBox.Text = rawWeather.GustSpeed + "km/h";
                        uvBox.Text = rawWeather.Uv;
                        windDirectionBox.Text = rawWeather.Winddirection + "°";


                        humidGuage.Value = float.Parse(rawWeather.Humidity);
                        temperatureGuage.Value = float.Parse(rawWeather.Temperature);
                        pressureGauge.Value = float.Parse(rawWeather.AirPressure);
                        windSpeedGauge.Value = float.Parse(rawWeather.Windspeed);
                        rainPrecipGauge.Value = float.Parse(rawWeather.Precipitation);
                        double precip = float.Parse(rawWeather.Precipitation);
                        rainPrecipitProgressBar.Value = (int)precip;
                        solarRadiationGauge.Value = float.Parse(rawWeather.SolarRadiation);
                        windGustGuage.Value = float.Parse(rawWeather.GustSpeed);
                        uvGauge.Value = float.Parse(rawWeather.Uv);
                        windDirectionGauge.Value = float.Parse(rawWeather.Winddirection);


                        humidGuage.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.Humidity), 2.5);              //  regulate color                      
                        temperatureGuage.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.Temperature), 1);
                        pressureGauge.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.AirPressure), 80);
                        windSpeedGauge.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.Windspeed), 0.9);
                        windGustGuage.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.GustSpeed), 0.9);
                        rainPrecipGauge.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.Precipitation), 4);
                        solarRadiationGauge.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.SolarRadiation), 80);
                        uvGauge.BaseArcColor = colorValue.SetColor(float.Parse(rawWeather.Uv), 0.1);

                        pressureTendpictureBox1.Image = pressureTendency.PressureIcon(rawWeather.AirPressureTendency);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string EpochToLocalTime(long input)
            {
                DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(input).LocalDateTime;
                return dateTime.ToString();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
            timeBox.Text = "Refreshed at:" + DateTime.Now.ToString();
        }

        private void MaxMincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MaxMincheckBox.Checked)
            {
                MaxMincheckBox.ForeColor = Color.Red;
                WeathercheckBox.Checked = false;
            }
            if (refreshButtonisClicked)
            {
                MaxMinPerDay maxMinDay = new(data);
                MaxMinTextBox.Text = maxMinDay.ShowMaxMinData();
            }
            MaxMinTextBox.Show();

            if (!MaxMincheckBox.Checked)
            {
                MaxMincheckBox.ForeColor = Color.Black;
                WeathercheckBox.Checked = true;
            }
        }

        private void RefreshButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WeathercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WeathercheckBox.Checked)
            {
                MaxMincheckBox.Checked = false;
            }
            MaxMinTextBox.Hide();
            if (!WeathercheckBox.Checked)
            {
                MaxMincheckBox.Checked = true;
            }
        }
    }
}
