using System;

namespace GitUp
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string GitFeature { get; set; }
        public string Git1 { get; set; }
        public string Git2 { get; set; }
    }
}
