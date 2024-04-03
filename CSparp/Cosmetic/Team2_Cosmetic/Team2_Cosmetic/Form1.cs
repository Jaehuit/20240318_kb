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
using Team2_Cosmetic;

namespace Cosmetic_AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection();

      
        private void ConnectDB()
        {
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
                cmd.CommandText = "select * from Process_Data"; //전송할 SQL문 작성
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DataToolStrip_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog(); //Show 말고 ShowDialog로 해야 함
            // refreshScreen();
        }

        private void ChartToolStrip_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            // refreshScreen();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }
    }
}
