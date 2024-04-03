using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject
{
    public abstract class DBHelper
    {
        protected SqlConnection conn = new SqlConnection();
        protected SqlDataAdapter da;
        protected DataSet ds;
        public DataTable dt;

        protected abstract void ConnectDB();

        public abstract void DoQuery(string ps = "-1", string ps2 = "-1"); // select 용

        public abstract void DoQuery(PData data); // insert, update, delete 용
    }
}