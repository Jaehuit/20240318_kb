using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetic_AI
{
    public class DataManager
    {
        public static List<ProcessData> Data= new List<ProcessData>();
        private static DBHelper_MSSQL mssql = DBHelper_MSSQL.getInstance; //싱글톤
    }
    

}
