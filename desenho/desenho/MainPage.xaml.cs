using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace desenho
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            //GetApi();
        }

        private async void StackLayout_LayoutChanged(object sender, EventArgs e)
        {
            
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://api.hgbrasil.com/weather?woeid=455876";
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(responseBody);
                double max = (double)data["results"]["forecast"][0]["max"];
                tempmax.Text = string.Format("{0}\u00B0", max);
                double min = (double)data["results"]["forecast"][0]["min"];
                tempmin.Text = string.Format("{0}\u00B0", min);
                double atual = (double)data["results"]["temp"];
                temp.Text = string.Format("{0}\u00B0" , atual);
                string cid = (string)data["results"]["city"];
                cidade.Text = cid;
                
                string diaa1 = (string)data["results"]["forecast"][1]["date"];
                dia1.Text = string.Format("{0}"+"       ", diaa1);
                double diamax1 = (double)data["results"]["forecast"][1]["max"];
                dia1max.Text = string.Format("{0}\u00B0", diamax1);
                double diamin1 = (double)data["results"]["forecast"][1]["min"];
                dia1min.Text = string.Format("{0}\u00B0"+ "      ", diamin1);

                string diaa2 = (string)data["results"]["forecast"][2]["date"];
                dia2.Text = string.Format("{0}" + "       ", diaa2);
                double diamax2 = (double)data["results"]["forecast"][2]["max"];
                dia2max.Text = string.Format("{0}\u00B0", diamax2);
                double diamin2 = (double)data["results"]["forecast"][2]["min"];
                dia2min.Text = string.Format("{0}\u00B0" + "      ", diamin2);

                string diaa3 = (string)data["results"]["forecast"][3]["date"];
                dia3.Text = string.Format("{0}" + "       ", diaa3);
                double diamax3 = (double)data["results"]["forecast"][3]["max"];
                dia3max.Text = string.Format("{0}\u00B0", diamax3);
                double diamin3 = (double)data["results"]["forecast"][3]["min"];
                dia3min.Text = string.Format("{0}\u00B0" + "      ", diamin3);

                string diaa4 = (string)data["results"]["forecast"][4]["date"];
                dia4.Text = string.Format("{0}" + "       ", diaa4);
                double diamax4 = (double)data["results"]["forecast"][4]["max"];
                dia4max.Text = string.Format("{0}\u00B0", diamax4);
                double diamin4 = (double)data["results"]["forecast"][4]["min"];
                dia4min.Text = string.Format("{0}\u00B0" + "      ", diamin4);

                string diaa5 = (string)data["results"]["forecast"][5]["date"];
                dia5.Text = string.Format("{0}" + "       ", diaa5);
                double diamax5 = (double)data["results"]["forecast"][5]["max"];
                dia5max.Text = string.Format("{0}\u00B0", diamax5);
                double diamin5 = (double)data["results"]["forecast"][5]["min"];
                dia5min.Text = string.Format("{0}\u00B0" + "      ", diamin5);

                string diaa6 = (string)data["results"]["forecast"][6]["date"];
                dia6.Text = string.Format("{0}" + "       ", diaa6);
                double diamax6 = (double)data["results"]["forecast"][6]["max"];
                dia6max.Text = string.Format("{0}\u00B0", diamax6);
                double diamin6 = (double)data["results"]["forecast"][6]["min"];
                dia6min.Text = string.Format("{0}\u00B0" + "      ", diamin6);



            }

        }

    }
}
