namespace SencorForm.Addons
{
    public class RawWeatherData
    {
        public RawWeatherData(dynamic data)
        {
            Temperature = data["current"]["temperature"];
            Humidity = data["current"]["humidity"];
            AirPressure = data["current"]["airpress_rel"];
            AirPressureTendency = data["current"]["tendency"];
            Precipitation = data["current"]["precipitation"];
            RainRate = data["current"]["rainrate"];
            Windspeed = data["current"]["windspeed"];
            GustSpeed = data["current"]["gustspeed"];
            Winddirection = data["current"]["winddirection"];
            Uv = data["current"]["uv"];
            SolarRadiation = data["current"]["solar"];
        }

        public string Temperature { get; private set; }

        public string Humidity { get; private set; }
        public string AirPressure { get; private set; }
        public string AirPressureTendency { get; private set; }
        public string Precipitation { get; private set; }
        public string RainRate { get; private set; }
        public string Windspeed { get; private set; }
        public string GustSpeed { get; private set; }
        public string Winddirection { get; private set; }
        public string Uv { get; private set; }
        public string SolarRadiation { get; private set; }
    }
}
