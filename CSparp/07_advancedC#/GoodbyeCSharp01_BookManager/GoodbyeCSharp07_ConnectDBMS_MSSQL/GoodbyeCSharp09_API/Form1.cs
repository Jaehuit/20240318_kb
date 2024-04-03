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

namespace GoodbyeCSharp09_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.Columns.AddRange("상호명", "소재지도로명주소");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //JSON 형식이라면 별도의 라이브러리(nuget패키지 활용) 필요
            //XML 형식이라면 별도의 라이브러리가 필요하진 않음
            string url = "https://api.odcloud.kr/api/3082925/v1/uddi:b4759786-c28c-41dd-b600-a9abdbec3ae1?page=1&perPage=10&returnType=xml&serviceKey=h9M7GaUlGnKYSCar7JWcHWxRiInhG2kALsv%2BFbCek5vGWe4C8COuOtL65YW2aeEOcs3%2Bqnv3yf42f73HgftdaA%3D%3D";
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            var jArray = JObject.Parse(json);
            var jData = jArray["data"];

            dataGridView1.Rows.Clear();
            foreach (var item in jData)
            {
                dataGridView1.Rows.Add(item["상호명"].ToString(), item["소재지도로명주소"]);
            }
        }
    }
}
