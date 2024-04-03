using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GoodByeCSharp10_mapAPI
{
    public class KakaoAPI
    {
        public static List<Locale> Search(string text)
        {
            List<Locale> list = new List<Locale>();

            //로컬 정보를 가져올 것임(이름과 좌표정보)
            //카카오 로컬 API 활용 예정(JSON)

            //요청 준비
            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={text}";
            string restAPIKey = "3e685244717691aa90147c7a9a34f612";
            string Header = $"KakaoAK {restAPIKey}";
            WebRequest req = WebRequest.Create(query);
            req.Headers.Add("Authorization", Header);

            //요청 보내서 응답 받기
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string json = reader.ReadToEnd();


            //이거 사용하기 위해선 newton 설치해야 한다. nuget에서...
            JavaScriptSerializer js = new JavaScriptSerializer();


            //dynamic = js의 let, var과 같은 것
            //변수의 타입이 유동적이다.
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;
            for (int i = 0; i < length; i++)
            {
                string name = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                list.Add(new Locale(name, y, x));
            }


            return list;
        }
    }
}
