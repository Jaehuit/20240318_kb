using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodbyeCSharp07_ConnectDBMS_MSSQL
{
    public partial class Form1 : Form
    {
        enum CRUD
        {
            INSERT,UPDATE=5,DELETE // 숫자에 이름 붙이는 것
        }
        public Form1()
        {
            InitializeComponent();
        }
        //DB연결을 보여주기 위해서 Form에다가 바로 DB연결 코드를 쓰고 있지만
        //이건 좋은 코드는 아님... 주차 관리 할 때는 DBHelper, DataManager로 분리예정
        private SqlConnection conn = new SqlConnection();
        private void ConnectDB() //트랜잭션 하기 전에 연결 후 완료 후에 연결끊기
        {//트랜잭션 : insert, update, delete 행동 단위, 하나의 트랜잭션이 insert문 하나 일 수도 있고 insert100개일 수도 있음
            conn.ConnectionString = $"Data Source=({"local"}); " +
                $"Initial Catalog = {"ProjectDataBase"}; Integrated Security = {"SSPI"}; Timeout={3}";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB(); //DBMS에 연결한 것
                SqlCommand cmd = new SqlCommand(); //SQL문 보낼 객체
                cmd.Connection = conn; //어디로 연결할 지 지정
                cmd.CommandText = "select * from testtable"; //전송할 SQL문 작성
                SqlDataAdapter da = new SqlDataAdapter(cmd); //SQL 데이터 처리할 변수
                DataSet ds = new DataSet(); //실제 데이터 저장할 객체
                da.Fill(ds, "mytest"); //da를 통해서 ds에 mytest라는 이름으로 sql 결과문을 넣음
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "mytest";
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close(); //java에서는 이 코드를 try catch 감싸야 하기도 함
            }
        }
        //SQL Injection(=SQL 삽입 공격) 방지를 위하여 별도의 파라메터로 값들을 설정
        //SQL 삽입 공격이란 비밀번호나 주요 정보를 탈취하기 위한 해킹 수법
        //직접적으로 SQL문을 적지 않고 간접적으로 적음
        private void sendQuery(string query, CRUD sqltype)
        {
            //ConnectDB();
            try
            {
                ConnectDB(); // 한 번 열었으면 한 번 닫아야 됨. 이미 열었는 데 또 열면 안 됨
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (sqltype == CRUD.UPDATE)
                {
                    MessageBox.Show("데이터 수정!");
                    //update table set name=@name where hakbeon=@hakbeon;
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@hakbeon", textBox1.Text);
                }
                else if (sqltype == CRUD.INSERT)
                {
                    MessageBox.Show("데이터 추가!");
                    //insert into table values(@hakbeon, @name);
                    //insert into table values('aa','bb');  //AddWithValue 쓸 땐 문자열이라고 해도 굳이 따옴표 필요없음
                    cmd.Parameters.AddWithValue("@hakbeon", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                }
                else if (sqltype == CRUD.DELETE)
                {
                    MessageBox.Show("데이터 삭제!");
                    //delete from table where hakbeon=@hakbeon
                    cmd.Parameters.AddWithValue("@hakbeon", textBox1.Text);
                }
                else
                {
                    MessageBox.Show("sqltype : " + sqltype);
                    return;
                }
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            sendQuery("insert into testtable values(@hakbeon,@name)", CRUD.INSERT);
            button1.PerformClick(); //실제 버튼 클릭한 것
        }

        private void button3_Click(object sender, EventArgs e)
        {

            sendQuery("update testtable set name=@name where hakbeon=@hakbeon", CRUD.UPDATE);
            button1_Click(null, null); //버튼 클릭했을 때 실행되는 메서드를 강제로 실행한 것 
        }

        private void button4_Click(object sender, EventArgs e)
        {

            sendQuery("delete from testtable where hakbeon=@hakbeon", CRUD.DELETE);
            button1.PerformClick(); //실제 버튼 클릭한 것
        }
    }
}