using Cosmetic_ex;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
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

namespace Cosmetic_ex
{
    public partial class Form4 : Form
    {
        public enum PDataFields
        {
            datetime,
            ReactA_Temp,
            ReactB_Temp,
            ReactC_Temp,
            ReactD_Temp,
            ReactE_Temp,
            ReactF_Temp,
            ReactF_PH,
            Power,
            CurrentA,
            CurrentB,
            CurrentC
        }

        public Form4()
        {
            InitializeComponent();
            DataManager.LoadP();
            // datetime between '2022-04-02' and '2022-04-09'
            loadCharts();
        }

        private PlotModel DrawGraph(string column)
        {
            // 데이터 생성
            var model = new PlotModel { Title = column };
            //var model = new PlotModel ();
            var series = new LineSeries
            {
                Title = "Data",
                MarkerType = MarkerType.Circle
            };

            if (DataManager.datasP.Count > 0)
            {
                foreach (var data in DataManager.datasP)
                {
                    series.Points.Add(
                        new DataPoint(
                            DateTimeAxis.ToDouble(data.datetime),
                            Convert.ToDouble(data.GetType().GetProperty(column).GetValue(data))
                            ));
                }
            }

            // 시리즈를 모델에 추가
            model.Series.Add(series);

            var dateTimeAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Date",
                IntervalType = DateTimeIntervalType.Days,
                StringFormat = "yyyy-MM-dd"
            };
            model.Axes.Add(dateTimeAxis);

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = column
            });

            // PlotView 컨트롤에 모델 할당
            return model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string where = textBox1.Text.ToString();
            DataManager.LoadP(where);
            loadCharts();
        }

        private void loadCharts()
        {
            plotView1.Model = DrawGraph(PDataFields.ReactA_Temp.ToString());
            plotView2.Model = DrawGraph(PDataFields.ReactB_Temp.ToString());
            plotView3.Model = DrawGraph(PDataFields.ReactC_Temp.ToString());
            plotView4.Model = DrawGraph(PDataFields.ReactD_Temp.ToString());
            plotView5.Model = DrawGraph(PDataFields.ReactE_Temp.ToString());
            plotView6.Model = DrawGraph(PDataFields.ReactF_Temp.ToString());
            plotView7.Model = DrawGraph(PDataFields.ReactF_PH.ToString());
            plotView8.Model = DrawGraph(PDataFields.Power.ToString());
            plotView9.Model = DrawGraph(PDataFields.CurrentA.ToString());
            plotView10.Model = DrawGraph(PDataFields.CurrentB.ToString());
            plotView11.Model = DrawGraph(PDataFields.CurrentC.ToString());
        }
    }
}