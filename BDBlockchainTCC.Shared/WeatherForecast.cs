﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BDBlockchainTCC.Shared
{
    public class WeatherForecast
    {
        public string ID { get; set; }
        public string Hash { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
