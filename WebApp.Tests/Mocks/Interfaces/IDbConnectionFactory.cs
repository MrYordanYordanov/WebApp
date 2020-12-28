using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WebApp.Tests.Mocks.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
