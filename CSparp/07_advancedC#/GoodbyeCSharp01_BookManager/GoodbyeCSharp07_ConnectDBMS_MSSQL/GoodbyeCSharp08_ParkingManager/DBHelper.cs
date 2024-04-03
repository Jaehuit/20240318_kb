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

    //나중에 혹시 다른 DBMS에 연동할 일 생기더라도
    //이 클래스를 상속받아서 쓰게 되면
    //어떻게 연결하는 지, 어떻게 쿼리 보내는 지는 미리 정의할 수 있게 됨
    public abstract class DBHelper
    {
        protected SqlConnection conn = new SqlConnection();
        protected SqlDataAdapter da;
        protected DataSet ds;
        public DataTable dt;

        protected abstract void ConnectDB();
        public abstract void DoQuery(string ps = "-1"); //select용
        public abstract void DoQuery(ParkingCar car); //update insert delete용으로 만들었으나...
        //주차 관리에서는 이 메서드를 업데이트용으로만 쓸 예정(주차/출차)

    }
}
