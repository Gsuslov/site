using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace site.Models
{
    public class Feedback
    {
        public int id { get; set; }

        public string Message { get; set; }

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public string feedback(string str)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM operator";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            DataRow dr = ds.Tables[0].Rows[0];
            conn.Close();
            return dr["email"].ToString(); // Поиск водоема
        }
    }
}
