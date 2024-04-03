using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp01_BookManager
{
    public partial class Form3 : Form
    {
        bool FindBook(Book x)
        {
            return x.userId == textBox1.Text;
        }
        public Form3()
        {
            InitializeComponent();
            //formPosition = centerScreen
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = null;
            if (DataManager.Users.Count > 0)
                dataGridView1.DataSource = DataManager.Users;

            dataGridView1.CellClick += DataGridView1_CellClick;

            //추가
            button1.Click += (s, e) =>
            {
                //Form2의 button1이랑 비교를 할 것
                //Exist 함수 : 괄호 안에 있는 람다식을 만족하는 x가 있으면 true
                //없으면 false
                //Exist 안에 함수 집어넣은 것!
                if (DataManager.Users.Exists(x => x.id == textBox1.Text))
                {
                    MessageBox.Show("해당 ID 이미 있음");
                }
                else
                {
                    User u = new User() { id = textBox1.Text, name = textBox2.Text };
                    DataManager.Users.Add(u);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Users;
                    DataManager.Save();
                }
            };
            //수정
            button2.Click += delegate (object s, EventArgs e)
            {
                try
                {
                    //Single = Users에 있는 내용 중 괄호 안에 있는 람다식을 만족하는 요소의 위치를 참조함
                    //만약 만족하는 게 하나도 없으면 exception을 발생시키므로 try catch 필수
                    //위치를 참조하므로 u의 값을 변경하면 Users의 해당 요소도 같이 변경이 됨
                    User u = DataManager.Users.Single(x => x.id == textBox1.Text);
                    u.name = textBox2.Text; //이름 변경
                    try
                    {
                        // Book b = DataManager.Books.Single
                        // (x=>x.userId==textBox1.Text);

                        //Book b=DataManager.Books.Single(
                        //delegate (Book x) { return x.userId == textBox1.Text; });


                        Book b = DataManager.Books.Single(FindBook);
                        b.userName = textBox2.Text;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                catch (Exception ex) //ex를 이용해 디버깅 할 수 있음
                {

                    MessageBox.Show("해당 ID는 없으므로 수정 불가능");
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
                DataManager.Save();
            };
            //삭제
            button3.Click += deleteUser;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //sender = dataGridView1을 의미
            User u = (sender as DataGridView).CurrentRow.DataBoundItem as User;
                textBox1.Text = u.id;
                textBox2.Text = u.name;
        }

        private void deleteUser(object s, EventArgs e)
        {
            try
            {
                User u = DataManager.Users.Single(x => x.id == textBox1.Text);
                DataManager.Users.Remove(u); //RemoveAt = 인덱스 이용해서 삭제
                //Remove = 값 혹은 위치를 활용해서 삭제함
                dataGridView1.DataSource = null;
                if(DataManager.Users.Count > 0)
                    dataGridView1.DataSource = DataManager.Users;
                DataManager.Save();
            }
            catch (Exception)
            {

               
            }
        }
    }
}
