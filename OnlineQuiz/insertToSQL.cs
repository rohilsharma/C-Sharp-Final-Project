using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace OnlineQuiz
{
    class insertToSQL
    {       
        public static void ExecuteSQL(string sqlCode)
        {
        SqlCeConnection cnn;
        SqlCeCommand cmd;

        string cnnstr = "Data Source=D:\\Visual C# Projects\\OnlineQuiz\\Database\\Library.sdf;Password=rohils;Persist Security Info=True";
        cnn = new SqlCeConnection(cnnstr);
        cmd = new SqlCeCommand(sqlCode, cnn);

        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();
       }
    }
}
