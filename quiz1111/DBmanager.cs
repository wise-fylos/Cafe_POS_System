using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace quiz1111
{
    internal class DBmanager
    {
        private static DBmanager instance_ = new DBmanager();

        public static DBmanager GetInstance()
        {
            return instance_;
        }

        private DBmanager()
        {
        }

        public void insert(string table, string value)
        {
            QueryBuilder.GetInstance().insert_into(table).values(value).exec();
        }

        public void update(string table, string value, string cond)
        {
            QueryBuilder.GetInstance().update(table).set(value).where(cond).exec();
        }

        public void delete(string from, string where)
        {
            QueryBuilder.GetInstance().delete().from(from).where(where).exec();
        }
    }
}
