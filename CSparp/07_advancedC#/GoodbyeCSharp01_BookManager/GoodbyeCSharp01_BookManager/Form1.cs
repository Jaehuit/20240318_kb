using GoodbyeCSharp01_BookManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GoodByeCSharp01_BookManager
{
    public partial class Form1 : Form
    {
        bool checkIsBorrowed(Book b)
        {
            return b.isBorrowed; //isBorrowed 는 t/f를 리턴함
        }
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //화면 중앙에 오게 하기, 디자인 창에서도 설정 가능
            refreshScreen();    //도서 관리나 사용자 관리의 변경 사항을 메인 화면에 바로 반영하기 위해서

            dataGridView1.CellClick += dBookCellClick;
            DataGridViewCellEventHandler dcell = dgUserClick;
            dataGridView2.CellClick += dcell;
        }

        void refreshScreen()
        {
            label1.Text = "전체 도서 수 : " + DataManager.Books.Count; //이 때 Load에 접근함
            label2.Text = "전체 회원 수 : " + DataManager.Users.Count;

            label3.Text = "대출 중인 도서의 수 : ";
            //람다식
            //label3.Text += DataManager.Books.Where( (x)=>x.isBorrowed ).Count() + "";
            //델리게이트 개념을 이해한다면 메서드 만들어서 대입할 수 있음
            label3.Text += DataManager.Books.Where(checkIsBorrowed).Count() + "";

            label4.Text = "연체 중인 도서의 수 :";
            //람다식
            //label4.Text += DataManager.Books.Where
            //    ( (x) => x.isBorrowed&&x.BorrowedAt.AddDays(7)<DateTime.Now).Count().ToString();
            label4.Text += DataManager.Books.Where
                (delegate (Book x) { return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now; }).Count() + "";

            bookBindingSource.Clear(); //초기화
            foreach (Book book in DataManager.Books)
            {
                bookBindingSource.Add(book);
            }
            /*
             bookBindingSource.DataSource=null;
             if (DataManager.Books.Count > 0)
                bookBindingSource.DataSource=DataManager.Books;
             */

            dataGridView2.DataSource = null; //null을 해주고 나서 DataSource를 바꿔야 
            //DataManager에 있는 Books나 Users의 변경 사항이 DataGridView에도 반영이 됨 
            if (DataManager.Users.Count > 0)
                dataGridView2.DataSource = DataManager.Users;

            dataGridView1.Refresh();
        }


        private void LibraryBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide();
            new Form2().ShowDialog(); //Show 말고 ShowDialog로 해야 함
            //Show();
            refreshScreen();
        }

        private void LibraryUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            refreshScreen();
        }

        //EventArgs를 넣어도 됨, 다형성에 의해서
        //즉 EventArgs e = new DataGridViewCellEventArgs(); 이게 된다는 의미
        //private void dCellClick(object s, DataGridViewCellEventArgs e)
        private void dBookCellClick(object s, EventArgs e)
        {
            DataGridView thisGridView = s as DataGridView;
            Book b = thisGridView.CurrentRow.DataBoundItem as Book;
            textBox1.Text = b.isbn;
            textBox2.Text = b.name;
        }

        //private void dgClick(object s, DataGridViewCellEventArgs e)
        private void dgUserClick(object s, EventArgs e)
        {
            User u = (s as DataGridView).CurrentRow.DataBoundItem as User;
            textBox3.Text = u.id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "") //양쪽 공백을 다 지웠는 데도 아무 것도 없다면
                MessageBox.Show("isbn없음");
            else if (textBox3.Text.Trim() == "")
                MessageBox.Show("사용자 id 없음");
            else
            {
                try
                {

                    Book b = DataManager.Books.Single(x => x.isbn == textBox1.Text);
                    if (b.isBorrowed) //이미 빌린 책이라면
                        MessageBox.Show("해당 책은 이미 빌렸습니다.");
                    else
                    {
                        User u = DataManager.Users.Single(x => x.id == textBox3.Text);
                        b.userId = u.id;
                        b.userName = u.name;
                        b.isBorrowed = true;
                        b.BorrowedAt = DateTime.Now;
                        DataManager.Save();
                        for (int i = 0; i < bookBindingSource.Count; i++)
                        {
                            if (b.isbn == (bookBindingSource[i] as Book).isbn)
                                bookBindingSource[i] = b;
                        }
                        refreshScreen(); //대출 중인 책의 수 갱신
                        MessageBox.Show($"{b.name}책이 {u.id}님에게 대여됨");

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("해당 ISBN을 가진 책은 없습니다. 대여 불가능!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("ISBN 누락!");
            else
            {
                try
                {
                    for (int i = 0; i < bookBindingSource.Count; i++)
                    {
                        if ((bookBindingSource[i] as Book).isbn == textBox1.Text)
                        {
                            Book b = DataManager.Books.Single(x => x.isbn == textBox1.Text);
                            if (b.isBorrowed)
                            {
                                b.userId = "";
                                b.userName = "";
                                b.isBorrowed = false;
                                DateTime oldDay = b.BorrowedAt; //빌렸던 시점
                                b.BorrowedAt = new DateTime(); // 초기화

                                DataManager.Save(); //파일에 반영

                                bookBindingSource[i] = b;

                                TimeSpan timeDiff = DateTime.Now - oldDay;
                                if (timeDiff.Days > 7)
                                    MessageBox.Show(b.isbn + "(" + b.name + ")" + "책 연체 반납");
                                else
                                    MessageBox.Show(b.isbn + "(" + b.name + ")" + "책 정상 반납");

                                refreshScreen(); //화면에 반영 //연체 반납중인 내용들도 모두 정상 처리 될 것
                            }
                            else
                            {
                                MessageBox.Show("아직 빌리지 않았으므로 반납 불가능");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("없는 책이므로 반납 불가능!");
                }
            }
        }
    }
}
