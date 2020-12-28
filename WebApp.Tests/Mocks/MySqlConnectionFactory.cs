using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebApp.Tests.Mocks.Interfaces;

namespace WebApp.Tests.Mocks
{
    public class MySqlConnectionFactory 
    {
        private const string myConnectionString = "server=127.0.0.1;uid=root;" +
  "pwd=1234;database=schooltest";
        protected MySqlConnection Connection { get; set; }

        public MySqlConnectionFactory()
        {
            this.Connection = new MySqlConnection(myConnectionString);
        }
    }
}
