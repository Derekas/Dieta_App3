using System;
using System.IO;

namespace Dietas_App.Model
{
    class Constants
    {
        public const string domini = "localhost";
        public const string UrlBase = "http://" + domini + "/institut(inventari/api/api.php/";
        public const string DatabaseFilename = "DietAppDB.db3";

        public const SQLite.SQLiteOpenFlags Flags =
        SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}