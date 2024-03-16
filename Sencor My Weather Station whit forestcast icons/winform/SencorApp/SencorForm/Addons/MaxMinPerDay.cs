using System.Text;

namespace SencorForm.Addons
{
    public class MaxMinPerDay
    {
        public MaxMinPerDay(dynamic data)
        {
            MinTemp = data["day"]["temp_min"];
            MinTempTime = data["day"]["temp_min_ts"];
            MaxTemp = data["day"]["temp_max"];
            MaxTempTime = data["day"]["temp_max_ts"];

            MinHumidd = data["day"]["hum_min"];
            MinHumiddTime = data["day"]["hum_min_ts"];
            MaxHummid = data["day"]["hum_max"];
            MaxHummidTime = data["day"]["hum_max_ts"];

            MinPressure = data["day"]["airp_rel_min"];
            MinPressureTime = data["day"]["airp_rel_min_ts"];
            MaXPressure = data["day"]["airp_rel_max"];
            MaxPressureTime = data["day"]["airp_rel_max_ts"];

            MaxGustSpeed = data["day"]["gustspeed_max"];
            MaxGustSpeedTime = data["day"]["gustspeed_max_ts"];

            MaxSolarRad = data["day"]["solar_max"];
            MaxSolarRadTime = data["day"]["solar_max_ts"];
        }

        public string MinTemp { get; private set; }
        public string MinTempTime { get; private set; }
        public string MaxTemp { get; private set; }
        public string MaxTempTime { get; private set; }
        public string MinHumidd { get; private set; }
        public string MinHumiddTime { get; private set; }
        public string MaxHummid { get; private set; }
        public string MaxHummidTime { get; private set; }
        public string MinPressure { get; private set; }
        public string MinPressureTime { get; private set; }
        public string MaXPressure { get; private set; }
        public string MaxPressureTime { get; private set; }
        public string MaxGustSpeed { get; private set; }
        public string MaxGustSpeedTime { get; private set; }
        public string MaxSolarRad { get; private set; }
        public string MaxSolarRadTime { get; private set; }
        public string ShowMaxMinData()
        {
            StringBuilder sb = new();
            sb.AppendLine("Min Temperature: " + MinTemp + "°C " + $"in {EpochToLocalTime(long.Parse(MinTempTime))}");
            sb.AppendLine("Max Temperature: " + MaxTemp + "°C " + $"in {EpochToLocalTime(long.Parse(MaxTempTime))}");
            sb.AppendLine();
            sb.AppendLine("Min Hummidity: " + MinHumidd + "% " + $"in {EpochToLocalTime(long.Parse(MinHumiddTime))}");
            sb.AppendLine("Max Hummidity: " + MaxHummid + "% " + $"in {EpochToLocalTime(long.Parse(MaxHummidTime))}");
            sb.AppendLine();
            sb.AppendLine("Min Pressure: " + MinPressure + "hPa " + $"in {EpochToLocalTime(long.Parse(MinPressureTime))}");
            sb.AppendLine("Max Pressure: " + MaXPressure + "hPa " + $"in {EpochToLocalTime(long.Parse(MaxPressureTime))}");
            sb.AppendLine();
            sb.AppendLine("Max Gust speed: " + MaxGustSpeed + "km/h " + $"in {EpochToLocalTime(long.Parse(MaxGustSpeedTime))}");
            sb.AppendLine("Max Solar Radiation: " + MaxSolarRad + "w/m² " + $"in {EpochToLocalTime(long.Parse(MaxSolarRadTime))}");

            return sb.ToString();
        }
        private string EpochToLocalTime(long input)
        {
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(input).LocalDateTime;
            return dateTime.ToString("HH:mm");
        }
    }
}
