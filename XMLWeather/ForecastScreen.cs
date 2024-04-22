using System;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date0.Text = Form1.days[0].date + "";
            min0.Text = Form1.days[0].tempLow + "°C";
            max0.Text = Form1.days[0].tempHigh + "°C";
            wind0.Text = Form1.days[0].windSpeed + "";
            windgust0.Text = Form1.days[0].windgust + "";
            rain0.Text = Form1.days[0].precipitation + "";

            date1.Text = Form1.days[1].date + "";
            min1.Text = Form1.days[1].tempLow + "°C";
            max1.Text = Form1.days[1].tempHigh + "°C";
            wind1.Text = Form1.days[1].windSpeed + "";
            windgust1.Text = Form1.days[1].windgust + "";
            rain1.Text = Form1.days[1].precipitation + "";

            date2.Text = Form1.days[2].date + "";
            min2.Text = Form1.days[2].tempLow + "°C";
            max2.Text = Form1.days[2].tempHigh + "°C";
            wind2.Text = Form1.days[2].windSpeed + "";
            windgust2.Text = Form1.days[2].windgust + "";
            rain2.Text = Form1.days[2].precipitation + "";

            min3.Text = Form1.days[3].tempLow + "°C";
            max3.Text = Form1.days[3].tempHigh + "°C";
            wind3.Text = Form1.days[3].windSpeed + "";
            date3.Text = Form1.days[3].date + "";
            windgust3.Text = Form1.days[3].windgust + ""; 
            rain3.Text = Form1.days[3].precipitation + "";

            date4.Text = Form1.days[4].date + "";
            min4.Text = Form1.days[4].tempLow + "°C";
            max4.Text = Form1.days[4].tempHigh + "°C";
            wind4.Text = Form1.days[4].windSpeed + "";
            windgust4.Text = Form1.days[4].windgust + "";
            rain4.Text = Form1.days[4].precipitation + "";

            date5.Text = Form1.days[5].date + "";
            min5.Text = Form1.days[5].tempLow + "°C";
            max5.Text = Form1.days[5].tempHigh + "°C";
            wind5.Text = Form1.days[5].windSpeed + "";
            windgust5.Text = Form1.days[5].windgust + "";
            rain5.Text = Form1.days[5].precipitation + "";

            date6.Text = Form1.days[6].date + "";
            min6.Text = Form1.days[6].tempLow + "°C";
            max6.Text = Form1.days[6].tempHigh + "°C";
            wind6.Text = Form1.days[6].windSpeed + "";
            windgust6.Text = Form1.days[6].windgust + "";
            rain6.Text = Form1.days[6].precipitation + "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
