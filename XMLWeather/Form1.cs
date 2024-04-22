using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day d = new Day();
                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("precipitation");
                d.precipitation = reader.GetAttribute("probability");
                double precipitation = Convert.ToDouble(d.precipitation);
                if (precipitation < 0.10)
                {
                    d.precipitation = "No Rain Today";
                }
                else
                {
                    d.precipitation = reader.GetAttribute("value");
                    if (reader.GetAttribute("value") == null)
                    {
                        d.precipitation = "No Rain Today!";
                    }
                }

                //if (reader.GetAttribute("probability") != "0")
                //{
                //    reader.ReadToFollowing("precipitation");
                //    d.precipitation = reader.GetAttribute("value");
                //}
                //else
                //{
                //    d.precipitation = "No rain today";
                //}

                reader.ReadToFollowing("windSpeed");
                d.windSpeed = reader.GetAttribute("mps");

                reader.ReadToFollowing("windGust");
                d.windgust = reader.GetAttribute("gust");

                //reader.ReadToFollowing("precipitation");



                reader.ReadToFollowing("temperature");
                d.tempHigh = reader.GetAttribute("max");
                d.tempLow = reader.GetAttribute("min");


                //TODO: if day object not null add to the days list
                days.Add(d);

            }
        }
        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("sun");
            days[0].sunset = reader.GetAttribute("set");
            days[0].sunrise = reader.GetAttribute("rise");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("feels_like");
            days[0].feelslike = reader.GetAttribute("value");

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");

            reader.ReadToFollowing("gusts");
            days[0].windgust = reader.GetAttribute("value");

            if (reader.ReadToFollowing("precipitation") == false)
            {
                days[0].precipitation = reader.GetAttribute("mode");
            }
            else
            {
                days[0].precipitation = "No rain today";
            }
        }
    }
}
