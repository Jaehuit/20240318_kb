using GoodbyeCSharp08_ParkingManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp08_ParkingManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(DataManager.Cars.Count > 0)  
            // 카운트가 0이하인데 중괄호 안에 코드 실행하면 켜지자마자 꺼지거나 혹은 셀 클릭할 때마다 오류가 남
            {
                dataGridView1.DataSource = DataManager.Cars;
                textBox1.Text = DataManager.Cars[0].parkingSpot;
                textBox2.Text = DataManager.Cars[0].carNumber;
                textBox3.Text = DataManager.Cars[0].driverName;
                textBox4.Text = DataManager.Cars[0].phoneNumber;
                textBox5.Text = textBox1.Text;
            }
        }

        private void writeLog(string contents)
        {
            DataManager.printLog(contents);
            string log = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]";
            log += contents;
            listBox1.Items.Insert(0, log); //최신 내용이 맨 위에 올라감
            //listBox1.Items.Add(contents); //최신 내용이 맨 아래로 내려감
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //writeLog("버튼 1 클릭(주차)");
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("주차 공간 번호 입력하세요(주차)");
            else if (textBox2.Text.Trim() == "")
                MessageBox.Show("차량 번호 입력해주세요.");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single
                        (x => x.parkingSpot == textBox1.Text.Trim());
                    if (car.carNumber.Trim() != "")
                        MessageBox.Show("해당 공간에 이미 차가 있습니다!");
                    else //주차 시작
                    {
                        car.parkingSpot = textBox1.Text.Trim();
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars; //sw(=화면)에 반영

                        DataManager.Save(car);//주차한 걸 db에 반영
                        string contents = $"주차공간 {car.parkingSpot}에 {car.carNumber}차를 주차함";
                        writeLog(contents);
                        MessageBox.Show(contents);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("해당 공간 없어서 주차 불가능!");
                    writeLog($"주차 공간{textBox1.Text} 존재하지 않음!");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //writeLog("버튼 2 클릭(출차)");
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("주차 공간 번호를 입력하세요(출차)");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single
                        (x => x.parkingSpot == textBox1.Text);
                    if (car.carNumber.Trim() == "")
                        MessageBox.Show("차가 없으므로 출차 불가능");
                    else
                    {
                        string oldCar = car.carNumber;//기존에 주차된 차
                        car.parkingSpot = textBox1.Text;
                        car.carNumber = "";
                        car.driverName = "";
                        car.phoneNumber = "";
                        car.parkingTime = new DateTime();
                        //car.parkingTime = DateTime.Parse("1753-01-01 오전 12:00:00");
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save(car);
                        string contents = $"주차공간 {car.parkingSpot} 에서 {oldCar} 출차";
                        writeLog(contents);
                        MessageBox.Show(contents);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"주차 공간{textBox1.Text} 없음(출차)");
                    writeLog($"주차 공간{textBox1.Text} 없음(출차)");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //조회
            try
            {
                ParkingCar car = DataManager.Cars.Single(x => x.parkingSpot == textBox5.Text);
                if (car.carNumber == "")
                {
                    MessageBox.Show($"{car.parkingSpot} 공간에는 차가 없음");
                    writeLog($"{car.parkingSpot} 공간에는 차가 없음");
                }
                else
                {
                    MessageBox.Show($"{car.parkingSpot} 공간에는 {car.carNumber} 있음");
                    writeLog($"{car.parkingSpot} 공간에는 {car.carNumber} 있음");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("해당 주차 공간 없음(조회 기능)");
            }
        }

        private void managingSpot(string parkingSpot, string cmd)//주차 공간 추가 or 삭제
        {
            parkingSpot = parkingSpot.Trim(); //공백 제거
            string contents = "";
            //bool check = DataManager.Save(cmd,parkingSpot, out contents);
            if (DataManager.Save(cmd, parkingSpot, out contents)) //추가든 삭제든 성공
                button6.PerformClick(); //전체 조회
            MessageBox.Show(contents);
            writeLog(contents);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // 주차공간 추가
            managingSpot(textBox5.Text, "insert");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 주차공간 삭제
            managingSpot(textBox5.Text, "delete");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 전체조회
            DataManager.Load();
            dataGridView1.DataSource = null;
            if (DataManager.Cars.Count > 0)
                dataGridView1.DataSource = DataManager.Cars;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParkingCar car = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
            textBox1.Text = car.parkingSpot;
            textBox2.Text = car.carNumber;
            textBox3.Text = car.driverName;
            textBox4.Text = car.phoneNumber;
            textBox5.Text = car.parkingSpot;
        }
    }
}
