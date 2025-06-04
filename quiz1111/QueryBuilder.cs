using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1111
{
    internal class QueryBuilder
    {
        private string q;
        private String strConn = "Data Source = ;" + "Database=; Uid=; Pwd=; CharSet = utf8;";

        private static QueryBuilder instance_ = new QueryBuilder();

        public static QueryBuilder GetInstance()
        {
            return instance_;
        }

        private QueryBuilder()
        {
        }

        public string getQ()
        {
            return q;
        }

        public void clearQ()
        {
            q="";
        }

        public string getConn()
        {
            return strConn;
        }

        public QueryBuilder select(string obj)
        {
            q += "SELECT " + obj + " ";
            return this;
        }

        public QueryBuilder delete()
        {
            q += "DELETE" + " ";
            return this;
        }

        public QueryBuilder update(string obj)
        {
            q += "UPDATE " + obj + " ";
            return this;
        }

        public QueryBuilder from(string obj)
        {
            q += "FROM " + obj + " ";
            return this;
        }

        public QueryBuilder where(string obj)
        {
            q += "WHERE " + obj + " ";
            return this;
        }

        public QueryBuilder insert_into(string obj)
        {
            q += "INSERT INTO " + obj + " ";
            return this;
        }

        public QueryBuilder values(string obj)
        {
            q += " VALUES " + obj;
            return this;
        }

        public QueryBuilder set(string obj)
        {
            q += "SET " + obj;
            return this;
        }

        public QueryBuilder group(string obj)
        {
            q += "GROUP BY " + obj;
            return this;
        }

        public void exec()
        {
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(this.q, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            clearQ();
        }
    }
}
