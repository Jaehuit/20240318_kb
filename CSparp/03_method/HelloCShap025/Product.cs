using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCShap025
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }

        //접근 제한자 없으면private 기본
        //해당 클래스 안에서만 접근됨
        string description { get; set; }
        private int vipPrice {  get; set; }    
        

        //생성자:new 키워드와 함께쓰이고 메모리 할당하는 시점에 뭘 할지 정해주는 것 
        //생성자를 적지 않아도 아래와 같이 아무것도 없는 생성자가 자동으로 생성됨
        public Product(string name,int price)
        {
            this.name = name;
            this.price = price;
        }
        
    }
}
