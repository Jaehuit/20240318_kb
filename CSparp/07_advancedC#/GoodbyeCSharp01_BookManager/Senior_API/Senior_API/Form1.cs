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

namespace Senior_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://api.odcloud.kr/api/15117724/v1/uddi:9180ce8d-5458-4769-bd8c-bc7ea827ff74?page=1&perPage=24&returnType=json&serviceKey=h9M7GaUlGnKYSCar7JWcHWxRiInhG2kALsv%2BFbCek5vGWe4C8COuOtL65YW2aeEOcs3%2Bqnv3yf42f73HgftdaA%3D%3D";
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            var jArray = JObject.Parse(json);
            var jData = jArray["data"];

            dataGridView1.Rows.Clear();
            foreach (var item in jData)
            {
                dataGridView1.Rows.Add(item["구분별(2)"].ToString(), item["55세 이상 근로자 (명)"], item["55세 이상 남성근로자 (명)"], item["55세 이상 여성근로자 (명)"]);
            }
        }
    }
}
