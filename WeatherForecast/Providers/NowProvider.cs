﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Contracts;

namespace WeatherForecast.Providers
{
    public class NowProvider : INowProvider
    {
        public DateTime Now() => DateTime.Now;
    }
}
