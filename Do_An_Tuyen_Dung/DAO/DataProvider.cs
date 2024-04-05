using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung.DAO
{
    public class DataProvider
    {
        private string connStr = "";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
        }
        /* vi du load data ra data gv thi tao ra string query xong goi DataProvider provider = new DataProvider();
        string query = ...
        DataProvider provider = new DataProvider();
        dtgriv.DataSource = provider.ExecuteQuery(query);

        PHẦN NÀY CHỈ LÀ DEMO
         */

    }
}
