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
    [Route("/Operator")]
    public class OperatorController : ControllerBase          
    {
        
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        [HttpPut("Operator_Create")]
        public string User_Create(string email, string password)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"INSERT INTO operator (email,password) VALUES (@email,@password)", conn);
            cmd.Parameters.Add(new NpgsqlParameter("email", email));
            cmd.Parameters.Add(new NpgsqlParameter("password", password));
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Оператор " + email + " успешно создан";

        }
        [HttpPost("Operator_PasswordUpdate")]
        public string User_PasswordUpdate(string email, string password)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"UPDATE operator SET password=@password WHERE email=@email", conn);
            cmd.Parameters.Add(new NpgsqlParameter("email", email));
            cmd.Parameters.Add(new NpgsqlParameter("password", password));
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Пароль оператора " + email + " успешно обновлен";

        }

        [HttpDelete("Operator_Delete")]
        public string User_Delete(string email)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"DELETE FROM operator WHERE email=@email", conn);
            cmd.Parameters.Add(new NpgsqlParameter("email", email));
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Оператор " + email + " удален";

        }

    }
    
}
