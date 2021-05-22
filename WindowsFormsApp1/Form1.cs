using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Settings settings;
        public Form1()
        {
            InitializeComponent();
            
        }

        string cityname;
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            cityname = textBox2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string response = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={cityname}&units=metric&appid=5933b7ccc81eecf5c24f9dc61c1826b9");
                settings = JsonConvert.DeserializeObject<Settings>(response);
            }
        }


        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string text3 = ("Скорость ветра: " + (settings.Wind.Speed.ToString())) +
                "                                                                                 " +
                "Град: " + (settings.Wind.Deg.ToString());
                MessageBox.Show(text3);

            }
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string text2 = ("Видимость: "+ (settings.Visibility.ToString()));
                MessageBox.Show(text2);
            }
        }

        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                string text1 = ("Облачность: " + (settings.Clouds.All.ToString()));
                MessageBox.Show(text1);
            }
        }


        public void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
               
                string text = ("Чувствуется: " + ((settings.Main.FeelsLike.ToString())) +
                "                                                                                 "+
                "Влажность: " + (settings.Main.Humidity.ToString()) +
                "                                                                                 " +
                "Давление: " + (settings.Main.Pressure.ToString()) +
                "                                                                                 " +
                "Температура: " + (settings.Main.Temp.ToString()) +
                "                                                                                 " +
                "Максимальная температура: " + (settings.Main.TempMax.ToString()) +
                "                                                    " +
                "Минимальная температура: " + (settings.Main.TempMin.ToString()));
                MessageBox.Show(text);

                
            }
        }

        public void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                string text4 = (
                "Скорость ветра: " + (settings.Wind.Speed.ToString()) +
                "                                                                                 " +
                "Град: " + (settings.Wind.Deg.ToString()) +
                "                                                                                             " +
                "Видимость: " + (settings.Visibility.ToString()) +
                "                                                                                           " +
                "Облачность: " + (settings.Clouds.All.ToString()) +

                "                                                                                 " +
                "Чувствуется: " + ((settings.Main.FeelsLike.ToString()) +
                "                                                                                 " +
                "Влажность: " + (settings.Main.Humidity.ToString()) +
                "                                                                                 " +
                "Давление: " + (settings.Main.Pressure.ToString()) +
                "                                                                                 " +
                "Температура: " + (settings.Main.Temp.ToString()) +
                "                                                                                 " +
                "Максимальная температура: " + (settings.Main.TempMax.ToString()) +
                "                                                    " +
                "Минимальная температура: " + (settings.Main.TempMin.ToString())));
                MessageBox.Show(text4);
            }
        }

        
    }
}
