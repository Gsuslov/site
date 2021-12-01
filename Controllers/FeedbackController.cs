using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace site.Controllers
{
    [ApiController]
    [Route("/Feedback")] 
    public class FeedbackController : Controller
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        [HttpPut("Feedback_Create")]
        public string Feedback_Create(string massage)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"INSERT INTO feedback (massage) VALUES (@massage)", conn);
            cmd.Parameters.Add(new NpgsqlParameter("massage", massage));
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Ваш коментарий: " + massage;
        }
        [HttpDelete("Feedback_Delete")]
        public string Feedback_Delete(int id)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"DELETE FROM feedback WHERE id=@id", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Коментарий успешно удален";


        }

    }
}
