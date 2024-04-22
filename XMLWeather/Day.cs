using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, country, tempHigh, tempLow, 
            windSpeed, windDirection, windgust,  precipitation, visibility, sunrise, sunset,  feelslike;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = country = tempHigh = tempLow
                = windSpeed = windDirection = windgust = precipitation = visibility = sunrise = sunset = feelslike =  "";
        }
    }
}
