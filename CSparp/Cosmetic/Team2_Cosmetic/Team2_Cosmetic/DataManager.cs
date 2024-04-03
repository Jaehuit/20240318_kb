using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace teamProject
{
    public class DataManager
    {
        public static List<PData> datas = new List<PData>();

        // 앞으로 DB와의 연락은 mssql이 모두 수행
        private static DBHelper_MSSQL mssql = DBHelper_MSSQL.getInstance; // 싱글톤

        public DataManager()
        {
            Load();
        }

        public static void Load() // 전체 불러오기
        {
            try
            {
                mssql.DoQuery(); // 전체 조회
                datas.Clear(); // datas 초기화
                foreach (DataRow item in mssql.dt.Rows)
                {
                    PData data = new PData();
                    data.datetime = item["datetime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["datetime"].ToString());
                    data.ReactA_Temp = double.Parse(item["ReactA_Temp"].ToString());
                    data.ReactB_Temp = double.Parse(item["ReactB_Temp"].ToString());
                    data.ReactC_Temp = double.Parse(item["ReactC_Temp"].ToString());
                    data.ReactD_Temp = double.Parse(item["ReactD_Temp"].ToString());
                    data.ReactE_Temp = double.Parse(item["ReactE_Temp"].ToString());
                    data.ReactF_Temp = double.Parse(item["ReactF_Temp"].ToString());
                    data.ReactF_PH = double.Parse(item["ReactF_PH"].ToString());
                    data.Power = double.Parse(item["Power"].ToString());
                    data.CurrentA = double.Parse(item["CurrentA"].ToString());
                    data.CurrentB = double.Parse(item["CurrentB"].ToString());
                    data.CurrentC = double.Parse(item["CurrentC"].ToString());
                    datas.Add(data);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                PrintLog(ex.StackTrace + "from Load");
            }
            finally
            {

            }
        }

        // contents = 로그 기록용
        public static bool Save(string cmd, string ps, out string contents) // 데이터 추가 삭제용 Save
        {
            // 해당 데이터 이미 있는지 여부 확인
            mssql.DoQuery(ps);

            contents = "";
            if (cmd.Equals("insert"))
            {
                return DBInsert(ps, ref contents);
            }
            else
            {
                return DBDelete(ps, ref contents);
            }
        }

        private static bool DBDelete(string ps, ref string contents)
        {
            if (mssql.dt.Rows.Count != 0)
            {
                mssql.deleteData(ps);
                contents = $"데이터 {ps}이/가 삭제";
                return true;
            }
            else // 해당 데이터 없음
            {
                contents = "해당 데이터 없음";
                return false;
            }
        }

        private static bool DBInsert(string ps, ref string contents)
        {
            mssql.insertData(ps);
            contents = $"데이터 {ps}이/가 추가";
            return true;
        }

        public static void Save(PData data) // 데이터 삭제용
        {
            mssql.DoQuery(data);
        }

        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("LogFolder");
            if (di.Exists == false) // 해당 폴더 없으면
            {
                di.Create(); // 폴더 생성
            }

            // @가 없으면 "LogFolder\\History.txt"
            // @은 \ 생략하고 \ ' " 사용할 수 있도록
            // 끝에 true는 append = true, 즉 History.txt에 새로운 내용을 밑에다가 계속 추가
            // 이게 없으면 내용 덮어쓰기라서 이전 log가 날아감.
            using (StreamWriter w = new StreamWriter(@"LogFolder\History.txt", true))
            {
                w.Write($"({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
                w.WriteLine(contents);
            }
        }

    }
}