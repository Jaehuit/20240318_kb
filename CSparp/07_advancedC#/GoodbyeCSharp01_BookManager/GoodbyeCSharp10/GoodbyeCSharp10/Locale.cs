using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp10_mapAPI
{
    public class Locale
    {
        public string name { get; set; }
        public double Lat { get; set; } //Y 좌표 의미함
        public double Lng { get; set; } //X 좌표 의미함

        //비어 있는 곳에 alt enter 치고 생성자 생성 클릭
        public Locale(string name, double lat, double lng)
        {
            this.name = name;
            Lat = lat;
            Lng = lng;
        }
        public override string ToString()
        {
            return name; //Lat Lng 말고 그냥 name 값만 리턴합시다.
        }



    }
}
