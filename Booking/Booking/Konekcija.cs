using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    class Konekcija
    {
        public String konekcija()
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = @"Data Source=DUSAN-PC;Initial Catalog=BookingDatabase;Integrated Security=True";
            return sql.ConnectionString;
        }
    }
}
