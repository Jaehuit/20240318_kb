using Cosmetic_ex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teamProject
{
    public partial class Form3 : Form
    {
        string placeholderText = "ex. 2024-01-01";
        public Form3()
        {
            InitializeComponent();
            Utils.reScreen(dataGridView1, "QData");
            placeholder.Text = placeholderText;
            placeholder.Enabled = false;
        }

        // 글자 입력되면 플레이스홀더 제거
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                placeholder.Visible = false;
            }
            else
            {
                placeholder.Visible = true;
            }
        }

        string select;

        // 셀 선택 시 textBox에 선택값 할당
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QData data = dataGridView1.CurrentRow.DataBoundItem as QData;
            //select = data.date.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
            select = data.date.ToString("yyyy-MM-dd");
            //textBox1.Text = data.date.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
            textBox1.Text = data.date.ToString("yyyy-MM-dd");
            textBox2.Text = data.weight.ToString();
            textBox3.Text = data.water.ToString();
            textBox4.Text = data.material.ToString();
            textBox5.Text = data.HSO.ToString();
            textBox6.Text = data.pH.ToString();
        }

        // 데이터 추가
        private void button1_Click(object sender, EventArgs e)
        {
            QData data = new QData();
            data.date = DateTime.Parse(textBox1.Text);
            data.weight = double.Parse(textBox2.Text);
            data.water = double.Parse(textBox3.Text);
            data.material = double.Parse(textBox4.Text);
            data.HSO = double.Parse(textBox5.Text);
            data.pH = double.Parse(textBox6.Text);

            DataManager.Save(data);
            MessageBox.Show($"{data.date.ToString("yyyy-MM-dd")} 데이터가 추가 되었습니다.");
            Utils.reScreen(dataGridView1, "QData");
        }

        // 데이터 수정
        private void button2_Click(object sender, EventArgs e)
        {
            QData data = new QData();
            data.weight = double.Parse(textBox2.Text);
            data.water = double.Parse(textBox3.Text);
            data.material = double.Parse(textBox4.Text);
            data.HSO = double.Parse(textBox5.Text);
            data.pH = double.Parse(textBox6.Text);

            DataManager.Update(data, select);
            MessageBox.Show($"{select} 데이터가 수정 되었습니다.");
            Utils.reScreen(dataGridView1, "QData");
        }

        // 선택 데이터 삭제
        private void button3_Click(object sender, EventArgs e)
        {
            // textBox1.Text와 동일한 datetime을 갖는 PData 객체 찾기
            //QData data = DataManager.datasQ.SingleOrDefault(x => x.date.ToString("yyyy-MM-dd HH:mm:ss.fffffff") == textBox1.Text);
            QData data = DataManager.datasQ.SingleOrDefault(x => x.date.ToString("yyyy-MM-dd") == textBox1.Text);
            if (data != null)
            {
                DataManager.Delete(data);
                MessageBox.Show($"{textBox1.Text} 데이터가 삭제 되었습니다.");
                Utils.reScreen(dataGridView1, "QData");
            }
            else
            {
                MessageBox.Show("해당하는 데이터가 없습니다.");
            }
        }


        // 텍스트 박스 초기화
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}