using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teamProject
{
    public class Utils
    {
        // 데이터 표시 포맷 - P or QData(Form2, 3)
        public static void Format(DataGridView dgv, string data, int digit)
        {
            if (data.Equals("PData"))
            {
                // 날짜 설정 :: 시, 분, 초 까지
                dgv.Columns["datetime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                // 소수점 이하 digit 자리까지만 표시되도록 설정
                string[] columns = { "ReactA_Temp", "ReactB_Temp", "ReactC_Temp", "ReactD_Temp", "ReactE_Temp",
            "ReactF_Temp", "ReactF_PH", "Power", "CurrentA", "CurrentB","CurrentC"};
                for (int i = 0; i < columns.Length; i++)
                {
                    dgv.Columns[columns[i]].DefaultCellStyle.Format = "N" + $"{digit}";
                }
            }

            if (data.Equals("QData"))
            {
                // 날짜 설정 :: 일 까지
                dgv.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                // 소수점 이하 digit 자리까지만 표시되도록 설정
                string[] columns2 = { "weight", "water", "material", "HSO", "pH" };
                for (int i = 0; i < columns2.Length; i++)
                {
                    dgv.Columns[columns2[i]].DefaultCellStyle.Format = "N" + $"{digit}";
                }
            }
        }

        // 데이터 표시 포맷, 시간은 초까지, 소수점은 digit 자리까지 - 2개(Form1)
        public static void Format(DataGridView dgv1, DataGridView dgv2, int digit)
        {
            dgv1.Columns["datetime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgv2.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd";

            // gridview1 소수점 이하 digit 자리까지만 표시되도록 설정
            string[] columns = { "ReactA_Temp", "ReactB_Temp", "ReactC_Temp", "ReactD_Temp", "ReactE_Temp",
            "ReactF_Temp", "ReactF_PH", "Power", "CurrentA", "CurrentB","CurrentC"};
            for (int i = 0; i < columns.Length; i++)
            {
                dgv1.Columns[columns[i]].DefaultCellStyle.Format = "N" + $"{digit}";
            }

            // gridview2 소수점 이하 digit 자리까지만 표시되도록 설정
            string[] columns2 = { "weight", "water", "material", "HSO", "pH" };
            for (int i = 0; i < columns2.Length; i++)
            {
                dgv2.Columns[columns2[i]].DefaultCellStyle.Format = "N" + $"{digit}";
            }
        }

        // 화면 리프레시 - 1개(Form2, 3)
        public static void reScreen(DataGridView dgv, string data, int digit)
        {
            dgv.DataSource = null;
            if (data.Equals("PData"))
            {
                DataManager.LoadP();
            }
            if (data.Equals("QData"))
            {
                DataManager.LoadQ();
            }

            if (data.Equals("PData") && DataManager.datasP.Count > 0)
            {
                dgv.DataSource = DataManager.datasP;
                dgv.Columns[0].Width = 150;
            }
            if (data.Equals("QData") && DataManager.datasQ.Count > 0)
            {
                dgv.DataSource = DataManager.datasQ;
                dgv.Columns[0].Width = 100;
            }
            Format(dgv, data, digit);
        }

        // 화면 리프레시 - 2개(Form1)
        public static void reScreen(DataGridView dgv1, DataGridView dgv2, int digit)
        {
            dgv1.DataSource = null;
            dgv2.DataSource = null;
            DataManager.LoadP();
            DataManager.LoadQ();
            if (DataManager.datasP.Count > 0 && DataManager.datasQ.Count > 0)
            {
                dgv1.DataSource = DataManager.datasP;
                dgv1.Columns[0].Width = 150;
                dgv2.DataSource = DataManager.datasQ;
                dgv2.Columns[0].Width = 100;
                Format(dgv1, dgv2, digit);
            }
        }

        // 화면 리프레시 - 조건
        public static void reScreen(DataGridView dgv, string data, string sql, int digit)
        {
            dgv.DataSource = null;
            if (data.Equals("PData"))
            {
                DataManager.LoadP(sql);
            }
            if (data.Equals("QData"))
            {
                DataManager.LoadQ(sql);
            }

            if (data.Equals("PData") && DataManager.datasP.Count > 0)
            {
                dgv.DataSource = DataManager.datasP;
                dgv.Columns[0].Width = 150;
            }
            if (data.Equals("QData") && DataManager.datasQ.Count > 0)
            {
                dgv.DataSource = DataManager.datasQ;
                dgv.Columns[0].Width = 100;
            }
            Format(dgv, data, digit);
        }

        // sql 컨버터
        public static string sqlQueryConverter(string text)
        {
            string query = "";
            string pattern = @"BETWEEN\((.+?),(.+?),(.+?)\)";

            char[] separators = { ';' };

            List<string> resultList = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                                  .ToList();

            for (int i = 0; i < resultList.Count; i++)
            {
                Match match = Regex.Match(resultList[i], pattern);
                string tempQ;

                if (match.Success)
                {
                    string value1 = match.Groups[1].Value;
                    string value2 = match.Groups[2].Value;
                    string value3 = match.Groups[3].Value;
                    tempQ = Between(value1, value2, value3);
                }
                else
                {
                    tempQ = resultList[i].ToString();
                }

                if (i == resultList.Count - 1)
                {
                    // 마지막 항목에 대한 처리
                    query += tempQ;
                }
                else
                {
                    // 마지막 항목이 아닌 경우에 대한 처리
                    query += tempQ + " AND ";
                }
            }
            return query;
        }

        delegate int Operation(int a, int b);

        static string Between(string q, string a, string b)
        {
            return $"{q} BETWEEN {a} AND {b}";
        }

        static void addQuery()
        {

        }

        static string queryWizard(string text)
        {
            string query = "";
            return query;
        }

        public static string[] pdata = new string[] { "datetime", "ReactA_Temp", "ReactB_Temp", "ReactC_Temp", "ReactD_Temp", "ReactE_Temp", "ReactF_Temp", "ReactF_PH", "Power", "CurrentA", "CurrentB", "CurrentC" };
        public static string[] qdata = new string[] { "date", "weight", "water", "material", "HSO", "pH" };
        public static string[] operators = new string[] { "=", "LIKE", ">", ">=", "<", "<=", "AND", "OR" };
    }
}