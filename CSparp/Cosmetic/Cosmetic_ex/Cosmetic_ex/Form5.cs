﻿using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tCosmetic_ex
{
    public partial class Form5 : Form
    {
        public enum QDataFields
        {
            date,
            weight,
            water,
            material,
            HSO,
            pH
        }

        public Form5()
        {
            InitializeComponent();
            DataManager.LoadQ();
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

            if (DataManager.datasQ.Count > 0)
            {
                foreach (var data in DataManager.datasQ)
                {
                    series.Points.Add(
                        new DataPoint(
                            DateTimeAxis.ToDouble(data.date),
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
            DataManager.LoadQ(where);
            loadCharts();
        }

        private void loadCharts()
        {
            plotView1.Model = DrawGraph(QDataFields.weight.ToString());
            plotView2.Model = DrawGraph(QDataFields.water.ToString());
            plotView3.Model = DrawGraph(QDataFields.material.ToString());
            plotView4.Model = DrawGraph(QDataFields.HSO.ToString());
            plotView5.Model = DrawGraph(QDataFields.pH.ToString());
        }
    }
}

