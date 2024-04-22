using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        double location, currenttemp, templow, temphigh, windspeed, windgust, precipitation, sunset, sunrise, feelslike;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }
        public void DisplayCurrent()
        {
            currenttemp = Convert.ToDouble(Form1.days[0].currentTemp);
            templow = Convert.ToDouble(Form1.days[0].tempLow);
            temphigh = Convert.ToDouble(Form1.days[0].tempHigh);
            windspeed = Convert.ToDouble(Form1.days[0].windSpeed);
            windgust = Convert.ToDouble(Form1.days[0].windgust);
            //sunset = Convert.ToDouble(Form1.days[0].sunset);
            //sunrise = Convert.ToDouble(Form1.days[0].sunrise);
            feelslike = Convert.ToDouble(Form1.days[0].feelslike);
            Math.Round(currenttemp, 1);

            degrelebel.Text = "°C";
            cityOutput.Text = Form1.days[0].location + "°C";
            currentOutput.Text = currenttemp + "°C";
            minOutput.Text = templow + "°C";
            maxOutput.Text = temphigh  + "°C";
            windlabel.Text = windspeed + "";
            gustlabel.Text = windgust + "";
            rainlabel.Text = Form1.days[0].precipitation + "";
            Sunsetlabel.Text = Form1.days[0].sunset + "";
            riselabel.Text = Form1.days[0].sunrise + "";
            feelslikelabel.Text = feelslike + "°C";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
