using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Services
{
    public class BaseEFService
    {
        protected MySqlConnection Connection { get; set; }

        public BaseEFService()
        {
            this.Connection = new MySqlConnection($"server=127.0.0.1;uid=root;" +
"pwd=1234;database=school");
        }
    }
}
