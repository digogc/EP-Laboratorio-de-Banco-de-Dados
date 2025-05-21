using Npgsql;
using System;
using System.Data;
using System.Text;

namespace base_bd2.Operation
{
    public class DbConnection : IDisposable
    {
        public string search_path = "SET search_path TO base_bd2;";
        public NpgsqlConnection Connection { get; set; }

        public DbConnection()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=base_bd2;User Id=postgres;Password=admin;");
            Connection.Open();
        }

        public NpgsqlCommand execCommand(string sSql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sSql, Connection);
            command.ExecuteNonQuery();
            return command;
        }

        public NpgsqlDataReader getReader(string sSql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sSql, Connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public DataTable getDataTable(string sSql)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlCommand command = new NpgsqlCommand(sSql, Connection))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}