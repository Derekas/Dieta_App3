 using Dietas_App3.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Model
{
    public class DataBase
    {
        public static SQLiteAsyncConnection ConnectionDatabase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>();
        static DataBase()
        {
            /*ConnectionDatabase.DropTableAsync<Dieta>().Wait();
            ConnectionDatabase.DropTableAsync<Comida>().Wait();
            ConnectionDatabase.DropTableAsync<Categoria>().Wait();*/

            ConnectionDatabase.CreateTableAsync<Dieta>().Wait();
            ConnectionDatabase.CreateTableAsync<Comida>().Wait();
            ConnectionDatabase.CreateTableAsync<Categoria>().Wait();
            ConnectionDatabase.CreateTableAsync<Usuario>().Wait();
        }
    }
}
