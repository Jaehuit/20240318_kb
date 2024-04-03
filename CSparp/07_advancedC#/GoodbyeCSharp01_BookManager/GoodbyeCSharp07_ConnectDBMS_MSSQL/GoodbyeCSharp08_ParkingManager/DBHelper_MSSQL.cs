using GoodbyeCSharp08_ParkingManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodByeCSharp08_ParkingManager
{
    public class DBHelper_MSSQL : DBHelper
    {
        //DoQuery() // ps 값은 자동으로 "-1"을 대입함
        //DoQuery("123") // ps 값을 "123"을 대입함

        private static DBHelper_MSSQL instance = null;

        public static DBHelper_MSSQL getInstance
        {
            get
            {
                if (instance == null)
                    instance = new DBHelper_MSSQL();
                return instance;
            }
        }

        private DBHelper_MSSQL() //private을 썼다는 건 외부에서 인스턴스 못 만듦
        {

        }




        protected override void ConnectDB()
        {
            conn.ConnectionString = $"Data Source=({"local"}); " +
                 $"Initial Catalog = {"ProjectDataBase"}; Integrated Security = {"SSPI"}; Timeout={3}";
            conn.Open();
        }
        public override void DoQuery(string ps = "-1") //select, 전체 or 특정 공간 정보
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (ps.Equals("-1")) //매개 변수 없는 경우
                    cmd.CommandText = "select * from parkingmanager";
                else
                {
                    cmd.CommandText = "select * from parkingmanager where parkingspot=@parkingspot";
                    cmd.Parameters.AddWithValue("@parkingspot", ps);
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "parkingManager");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                DataManager.printLog(ex.Message);
                DataManager.printLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        //isremove = 주차 혹은 출차 여부
        public override void DoQuery(ParkingCar car)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string sql = "";
                sql = "update parkingmanager set carnumber=@carnumber," +
                    "drivername=@drivername,phonenumber=@phonenumber," +
                    "parkingtime=@parkingtime where parkingspot=@parkingspot";
                cmd.Parameters.AddWithValue("@carnumber", car.carNumber);
                cmd.Parameters.AddWithValue("@drivername", car.driverName);
                cmd.Parameters.AddWithValue("@phonenumber", car.phoneNumber);
                cmd.Parameters.AddWithValue("@parkingtime", car.parkingTime);
                cmd.Parameters.AddWithValue("@parkingspot", car.parkingSpot);
                if (car.carNumber == "") //차뺀다는 의미
                {
                    sql = "update parkingmanager set carnumber=@carnumber," +
                        "drivername=@drivername,phonenumber=@phonenumber," +
                        "parkingtime='' where parkingspot=@parkingspot";
                    cmd.Parameters.RemoveAt(3);  // @parkingtime 삭제
                }
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                DataManager.printLog(ex.Message);
                DataManager.printLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        //주차 공간 추가 및 삭제 코드
        private void spotManagingQuery(string ps, string cmd)
        {
            string sql = "";
            cmd = cmd.ToLower();
            if (cmd.Equals("insert"))
            {
                sql = "insert into parkingmanager(parkingspot) values(@ps)";
            }
            else
            {
                sql = "delete from parkingmanager where parkingspot = @ps";
            }
            try
            {
                ConnectDB();
                SqlCommand sqlCommand = new SqlCommand();
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = conn;
                sqlCommand.Parameters.AddWithValue("@ps", ps);
                sqlCommand.CommandText = sql;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                DataManager.printLog(ex.Message);
                DataManager.printLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        public void deleteParkingSpot(string ps)
        {
            spotManagingQuery(ps, "delete");
        }
        public void insertParkingSpot(string ps)
        {
            spotManagingQuery(ps, "insert");
        }
    }
}
