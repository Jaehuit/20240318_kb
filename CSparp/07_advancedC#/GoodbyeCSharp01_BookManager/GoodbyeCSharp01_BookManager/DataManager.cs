using GoodbyeCSharp01_BookManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoodByeCSharp01_BookManager
{
    public class DataManager
    {
        //클래스 변수
        //DataManager 클래스 자체로 접근이 가능함
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        //정적 생성자
        //딱 한 번만 호출되고, 다른 코드에서 DataManager가 처음 나타날 때
        //자동 호출됨
        static DataManager()
        {
            Load();
        }
        //태그를 쓸 때 오타를 최소화하는 방법
        const string ISBN = "isbn";
        const string NAME = "name"; //책 제목 및 사람 이름을 의미
        const string PUBLISHER = "publisher";
        const string PAGE = "page";
        const string USERID = "userid";
        const string USERNAME = "username";
        const string ISBORROWED = "isborrowed";
        const string BORROWEDAT = "borrowedat";
        const string ID = "id";

        public static void Load() //도서 정보랑 유저 정보를 xml 파일에서 읽어오는 함수
        {
            try
            {
                // ./Books.xml : exe파일이 있는 곳과 같은 경로에 xml 파일이 있을 경우
                string booksOutput = File.ReadAllText("./Books.xml");  // using System.IO;
                XElement bx = XElement.Parse(booksOutput);  // string을 xml형태로 변환함
                Books.Clear();
                foreach (var item in bx.Descendants("book"))   // LINQ대신  foreach문으로 파일 읽는 중
                {
                    Book book = new Book();
                    book.isbn = item.Element(ISBN).Value;
                    book.name = item.Element(NAME).Value;
                    book.publisher = item.Element(PUBLISHER).Value;
                    book.page = int.Parse(item.Element(PAGE).Value);
                    book.BorrowedAt = DateTime.Parse(item.Element(BORROWEDAT).Value);
                    book.isBorrowed = item.Element(ISBORROWED).Value != "0" ? true : false;
                    book.userId = item.Element(USERID).Value;
                    book.userName = item.Element(USERNAME).Value;
                    Books.Add(book);
                }

                string usersOutput = File.ReadAllText("./Users.xml");
                XElement ux = XElement.Parse(usersOutput);
                //LINQ 쓸 거라면 Clear안쓸거임
                Users = (from item in ux.Descendants("user")
                         select new User()
                         {
                             id = item.Element(ID).Value,
                             name = item.Element(NAME).Value
                         }).ToList<User>();


            }
            catch (Exception ex)//FileLoadException을 쓰면 또 다른 Exception은 대비가 안 됨
            {
                Save(); //없을 경우 파일을 만들고
                Load(); //다시 로드함, 파일이 잘못 만들어졌거나 읽는 거 자체가 잘못될 경우 무한루프됨
            }
        }
        public static void Save()//도서 정보랑 유저 정보를 xml 파일에 저장하는 함수
        {
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach (var item in Books)
            {
                booksOutput += "    <book>" + Environment.NewLine;
                booksOutput += $"       <{ISBN}>{item.isbn}</{ISBN}>" + Environment.NewLine;
                booksOutput += $"       <{NAME}>{item.name}</{NAME}>" + Environment.NewLine;
                booksOutput += $"       <{PUBLISHER}>{item.publisher}</{PUBLISHER}>" + Environment.NewLine;
                booksOutput += $"       <{PAGE}>{item.page}</{PAGE}>" + Environment.NewLine;
                booksOutput += $"       <{BORROWEDAT}>{item.BorrowedAt}</{BORROWEDAT}>" + Environment.NewLine;
                booksOutput += $"       <{ISBORROWED}>" + (item.isBorrowed ? 1 : 0) + $"</{ISBORROWED}>" + Environment.NewLine;
                booksOutput += $"       <{USERID}>{item.userId}</{USERID}>" + Environment.NewLine;
                booksOutput += $"       <{USERNAME}>{item.userName}</{USERNAME}>" + Environment.NewLine;
                booksOutput += "    </book>" + Environment.NewLine;
            }
            booksOutput += "</books>";
            File.WriteAllText("./Books.xml", booksOutput);

            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                usersOutput += "    <user>\n";
                usersOutput += $"       <{ID}>{item.id}</{ID}>\n";
                usersOutput += $"       <{NAME}>{item.name}</{NAME}>\n";
                usersOutput += "    </user>\n";
            }
            usersOutput += "</users>\n";
            File.WriteAllText("./Users.xml", usersOutput);
        }
    }
}
