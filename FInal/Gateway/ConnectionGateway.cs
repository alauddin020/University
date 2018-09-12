using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FInal.Gateway
{
    public class ConnectionGateway
    {
        public SqlConnection Connection;
        string con = @"Data Source=ALAUDDINFA;Initial Catalog=University;Integrated Security=True";
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        public ConnectionGateway()
        {
            Connection = new SqlConnection(con);
        }
    }
}