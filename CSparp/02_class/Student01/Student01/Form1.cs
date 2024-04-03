using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student01
{
    //인터널로 안되는게 퍼블릭으로는 가능
    public partial class Form1 : Form

    {
        public class Student
        {
            public string name { get; set; }
            public int grade { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준", grade = 1 });
            students.Add(new Student() { name = "동준이", grade = 2 });
            students.Add(new Student() { name = "준동이", grade = 3 });
            students.Add(new Student() { name = "준준이", grade = 4 });
            students.Add(new Student() { name = "동동이", grade = 1 });
            students.Add(new Student() { name = "이이이", grade = 2 });
            students.Add(new Student() { name = "이동훈", grade = 1 });

            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label(); //코드상 라벨 생성
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true;     //라벨 크기가 자동으로 늘어나는 명령어 /긴 글자는 잘릴 수 있음
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);       //없으면 화면에 나타나지 않음
            }
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 1)
                    students.RemoveAt(i);
            }
            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label(); //코드상 라벨 생성
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true;     //라벨 크기가 자동으로 늘어나는 명령어 /긴 글자는 잘릴 수 있음
                label.Location = new Point(130, 13 + (23 + 3) * i);
                Controls.Add(label);       //없으면 화면에 나타나지 않음
            }

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
