using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp01_BookManager
{
    public class Book
    {
        public string isbn { get; set; } //책의 고유 번호
        public string name { get; set; } //책 이름
        public string publisher { get; set; } //출판사명
        public int page { get; set; }//페이지수
        public string userId { get; set; }//빌린 사람의 ID(일종의 FK)
        public string userName { get; set; }//빌린 사람의 이름(DB로 치자면 Inner Join으로 얻을 수 있는 값)
        public bool isBorrowed { get; set; }//대출 여부(빌렸는 지 여부)
        public DateTime BorrowedAt { get; set; } //언제 빌렸는 지 날짜
    }
}
