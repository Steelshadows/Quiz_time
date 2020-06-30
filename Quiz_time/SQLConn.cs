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
        public SQLConn()
        {
        }
        private MySqlConnection Conn = new MySqlConnection("Server=localhost;Database=quizTime;user=root;Pwd=;");
        public string[] executeQuery(string query, string[][] qParams){
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            string[] res = { "res created" };
            if(qParams.GetLength(0) > 0)
            {
                for (int x = 0; x < qParams.GetLength(0); x += 1)
                {
                    cmd.Parameters.AddWithValue(qParams[x][0], qParams[x][1]);                
                }
            }
            Conn.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Conn.Close();


            return res;
        }
        public DataTable selectQuery(string query, string[][] qParams = null)
        {
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            DataTable queryResults = new DataTable();
            if (qParams != null && qParams.GetLength(0) > 0)
            {
                for (int x = 0; x < qParams.GetLength(0); x += 1)
                {
                    cmd.Parameters.AddWithValue(qParams[x][0], qParams[x][1]);                
                }
            }
            Conn.Open();
            queryResults.Load(cmd.ExecuteReader());
            Conn.Close();


            return queryResults;
        }

    }
}
