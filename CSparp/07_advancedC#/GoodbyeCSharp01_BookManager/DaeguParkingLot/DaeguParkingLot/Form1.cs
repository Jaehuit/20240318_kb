using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaeguParkingLot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string url = "https://api.odcloud.kr/api/15006436/v1/uddi:35dc3772-f2eb-40d8-aaa3-cb5d19c0ce60?page=1&perPage=20&returnType=json&serviceKey=h9M7GaUlGnKYSCar7JWcHWxRiInhG2kALsv%2BFbCek5vGWe4C8COuOtL65YW2aeEOcs3%2Bqnv3yf42f73HgftdaA%3D%3D";
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            var jArray = JObject.Parse(json);
            var jData = jArray["data"];

            dataGridView1.Rows.Clear();
            foreach (var item in jData)
            {
                dataGridView1.Rows.Add(item["역명"].ToString(), item["위치"], item["비고"]);
            }


        }
    }
}
