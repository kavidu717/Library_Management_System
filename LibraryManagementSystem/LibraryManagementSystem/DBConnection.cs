using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    internal class DBConnection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=LibraryManagementSystem;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
