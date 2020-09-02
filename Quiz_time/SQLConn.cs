using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Quiz_time
{
    class SQLConn
    {
        private MySqlConnection Conn = new MySqlConnection("Server=localhost;Database=quizTime;user=root;Pwd=;");
        public SQLConn()
        {
        }
        public string[] executeQuery(string query, List<string[]> qParams = null)
        {
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            string[] res = { "res created" };
            if (qParams != null && qParams.Count() > 0)
            {
                foreach (string[] qParam in qParams)
                {
                    cmd.Parameters.AddWithValue(qParam[0], qParam[1]);
                }
            }
            Conn.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Conn.Close();


            return res;
        }
        public DataTable selectQuery(string query, List<string[]> qParams = null)
        {
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            DataTable queryResults = new DataTable();
            if (qParams != null && qParams.Count() > 0) {
                foreach (string[] qParam in qParams) { 
                    cmd.Parameters.AddWithValue(qParam[0], qParam[1]);   
                }
            }
            Conn.Open();
            queryResults.Load(cmd.ExecuteReader());
            Conn.Close();


            return queryResults;
        }

    }
}
