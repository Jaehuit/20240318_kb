using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_AI
{
    public class DBHelper_MSSQL : DBHelper        
    {
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

        public override void DoQuery(string ps = "-1")  // selest
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (ps.Equals("-1")) //매개 변수 없는 경우
                    cmd.CommandText = "select * from Process_Data";
                else
                {
                    cmd.CommandText = "select * from Process_Data where datetime=@datetime";
                    cmd.Parameters.AddWithValue("@datetime", ps);
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Process_Data");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                // DataManager.printLog(ex.Message);
                // DataManager.printLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        /* public override void DoQuery(ProcessData cos)
        {

            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string sql = "";
                sql = "update Process_Data set datetime=@datetime," +
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
        */
    }
}
