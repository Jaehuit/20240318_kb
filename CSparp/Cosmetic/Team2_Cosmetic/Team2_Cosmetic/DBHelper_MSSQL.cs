using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetic_AI;

namespace teamProject
{
    public class DBHelper_MSSQL : DBHelper
    {
        // 싱글톤 적용
        // 얘를 계속 돌려씀
        private static DBHelper_MSSQL instance;
        public static DBHelper_MSSQL getInstance
        {
            get
            {
                if (instance == null) // 없으면 인스턴스 하나 만들고
                {
                    instance = new DBHelper_MSSQL();
                }
                return instance; // 있으면 계속 재활용
            }
        }
        private DBHelper_MSSQL() { } // 외부에서 인스턴스 못 만들게

        protected override void ConnectDB()
        {
            conn.ConnectionString = $"Data Source=({"local"}); " +
                $"Initial Catalog = {"ProjectDataBase"}; Integrated Security = {"SSPI"}; Timeout={3}";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        // DoQuery() // ps 값은 자동으로 "-1"을 대입
        // DoQuery("123") // ps 값을 "123"을 대입함
        // 즉, 기본값 설정하는 방법
        public override void DoQuery(string ps = "-1", string ps2 = "-1") // select 전체 or 특정 데이터 정보
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (ps.Equals("-1")) // 매개 변수 없는 경우
                {
                    cmd.CommandText = "select * from Process_Data";
                }
                else
                {
                    cmd.CommandText = "select * from Process_Data where datetime between  @start AND @end;";
                    cmd.Parameters.AddWithValue("@a", ps);
                    cmd.Parameters.AddWithValue("@b", ps2);
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Process_Data");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                //System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                DataManager.PrintLog(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public override void DoQuery(PData data)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string sql = "";
                sql = "update Process_Data set currentA=@currentA where currentB=@currentB";
                cmd.Parameters.AddWithValue("@currentA", data.CurrentA);
                cmd.Parameters.AddWithValue("@currentB", data.CurrentB);

                if (data.CurrentA.ToString() == "") // 삭제 시
                {
                    sql = "update parkingLot set currentA=@currentA where currentB=@currentB";
                }

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                //System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                DataManager.PrintLog(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public void deleteData(string ps)
        {

        }
        public void insertData(string ps)
        {

        }
    }
}