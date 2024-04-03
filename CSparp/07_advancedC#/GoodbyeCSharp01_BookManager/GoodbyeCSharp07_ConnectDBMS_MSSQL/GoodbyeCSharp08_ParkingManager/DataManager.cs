using GoodbyeCSharp08_ParkingManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp08_ParkingManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        private static DBHelper_MSSQL mssql = DBHelper_MSSQL.getInstance; //싱글톤

        static DataManager()
        {
            Load();
        }

        public static void Load() //전체 불러오기
        {
            try
            {
                mssql.DoQuery(); //전체 조회
                Cars.Clear(); //Cars 초기화
                foreach (DataRow item in mssql.dt.Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.parkingSpot = item["parkingspot"].ToString();
                    car.carNumber = item["carnumber"].ToString();
                    car.driverName = item["drivername"].ToString();
                    car.phoneNumber = item["phonenumber"].ToString();
                    car.parkingTime = item["parkingtime"].ToString() == "" ? new DateTime() :
                    DateTime.Parse(item["parkingtime"].ToString());
                    Cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.StackTrace + " from Load ");
            }
        }
        //contents = 로그(=기록)남길 때 쓸 것임
        public static bool Save(string cmd, string ps, out string contents) //주차 공간 추가 삭제용 Save
        {

            //해당 공간 이미 있는 지 여부 체크
            mssql.DoQuery(ps);

            contents = "";
            if (cmd.Equals("insert"))
                return DBInsert(ps, ref contents);
            else
                return DBDelete(ps, ref contents);
        }

        private static bool DBDelete(string ps, ref string contents)
        {
            if (mssql.dt.Rows.Count != 0)
            {
                mssql.deleteParkingSpot(ps);
                contents = $"주차공간 {ps} 삭제";
                return true;
            }
            else //주차 공간 없음
            {
                contents = "해당 공간 없음";
                return false;
            }
        }

        private static bool DBInsert(string ps, ref string contents)
        {
            if (mssql.dt.Rows.Count == 0)
            {
                mssql.insertParkingSpot(ps);
                contents = $"주차공간 {ps} 추가";
                return true;
            }
            else
            {
                contents = "해당 공간 이미 있음";
                return false;
            }
        }

        public static void Save(ParkingCar car) //주차 출차용
        {
            mssql.DoQuery(car);
        }

        public static void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("LogFolder");
            if (di.Exists == false) //해당 폴더 없으면
                di.Create(); //폴더 생성

            //@가 없으면 "LogFolder\\History.txt"
            //끝에 true는 append = true, 즉 History.txt에 새로운 내용을 밑에다가 계속 추가함
            //이거 없으면 계속 내용 덮어쓰기만 해서 과거 내용이 계속 지워짐
            using (StreamWriter w = new StreamWriter(@"LogFolder\History.txt", true))
            {
                w.Write($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]");
                w.WriteLine(contents);
            }
        }
    }
}
