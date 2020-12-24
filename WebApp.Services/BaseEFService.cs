using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Services
{
    public class BaseEFService
    {
        private const string myConnectionString = "server=127.0.0.1;uid=root;" +
"pwd=1234;database=school";
        protected MySqlConnection Connection { get; set; }

        public BaseEFService()
        {
            this.Connection = new MySqlConnection(myConnectionString);
        }
    }
}
