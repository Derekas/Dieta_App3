using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    public class DataBase
    {
        public static SQLiteAsyncConnection ConnectionDatabase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>();
        static DataBase()
        {
            ConnectionDatabase.CreateTableAsync<Dieta>().Wait();
            ConnectionDatabase.CreateTableAsync<Comida>().Wait();
        }
    }
}
