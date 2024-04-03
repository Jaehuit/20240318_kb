using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloCSharp056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //https://www.weather.go.kr/w/rss/dfs/hr1-forecast.do?zone=2714055500
                string url = "https://www.weather.go.kr/w/rss/dfs/hr1-forecast.do?zone=2714055500";
                XElement x = XElement.Load(url); //url 사이트에 있는 xml 문서를 불러 옴
                var xq = from item in x.Descendants("data") select item;
                foreach (var item in xq)
                    Console.WriteLine(item); //xml 문서를 그대로 긁어와서 뿌린 것
                foreach (var item in xq) //xml 문서 중 일부 태그만 가져온 것
                {
                    Console.WriteLine("시간:" + item.Element("hour").Value);
                    Console.WriteLine("온도:" + item.Element("temp").Value);
                    Console.WriteLine("날씨:" + item.Element("wfKor").Value);
                }
                var xmlQuery = from item in x.Descendants("data") //xml 문서의 일부 태그를 익명객체 데이터 형태로 가공해서 가져옴
                               select
                               new 
                               {
                                   Hour = item.Element("hour").Value,
                                   Temp = item.Element("temp").Value,
                                   wfKor = item.Element("wfKor").Value
                               };
                foreach (var item in xmlQuery)
                {
                    Console.WriteLine("시간:" + item.Hour);
                    Console.WriteLine("온도:" + item.Temp);
                    Console.WriteLine("날씨:" + item.wfKor);
                }

            }
        }
    }
}
