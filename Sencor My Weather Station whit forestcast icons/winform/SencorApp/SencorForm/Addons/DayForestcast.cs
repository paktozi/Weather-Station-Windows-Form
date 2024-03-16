using System.Text;

namespace SencorForm.Addons
{
    public class DayForestcast
    {
        public DayForestcast(dynamic data, string day)
        {
            IconNumber = data["forecast"][day]["fc_icon"];
            TextCondition = data["forecast"][day]["fc_text"];
            TempMin = "Min Temp " + data["forecast"][day]["fc_temp_min"] + "°C";
            TempMax = "Max Temp: " + data["forecast"][day]["fc_temp_max"] + "°C";
            RainSum = "Rain Sum: " + data["forecast"][day]["fc_rainsum"] + "mm";
            RainPossibility = "Rain Possib " + data["forecast"][day]["fc_rain_possibility"] + "%";
        }

        public string IconNumber { get; private set; }
        public string TextCondition { get; private set; }
        public string TempMin { get; private set; }
        public string TempMax { get; private set; }
        public string RainSum { get; private set; }
        public string RainPossibility { get; private set; }

        public string GetWeatherData()
        {
            StringBuilder sb = new();
            sb.AppendLine(TextCondition);
            sb.AppendLine();
            sb.AppendLine(TempMax);
            sb.AppendLine(TempMin);
            sb.AppendLine(RainSum);
            sb.AppendLine(RainPossibility);
            return sb.ToString();
        }
    }
}
