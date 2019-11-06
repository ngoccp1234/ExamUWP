using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace ExamUWP.Ultil
{
    class SQLUltil
    {
        private const string DatabaseName = "contact.db";

        private static SQLUltil _instance;
        public SQLiteConnection Connection { get; }

        public static SQLUltil GetIntances()
        {
            if (_instance == null)
            {
                _instance = new SQLUltil();
            }
            return _instance;
        }

        private SQLUltil()
        {
            Connection = new SQLiteConnection(DatabaseName);
            CreateTables();
        }

        private void CreateTables()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS Contact (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),NumberPhone VARCHAR( 140 ));";
            using (var statement = Connection.Prepare(sql))
            {
                statement.Step();
            }
        }
    }
}
