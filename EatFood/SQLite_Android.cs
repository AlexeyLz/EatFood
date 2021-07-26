using System.Collections.Generic;
using System.Linq;
using System.Text;
using EatFood.Droid;
using System.IO;
using Xamarin.Forms;
using System;

[assembly: Dependency(typeof(SQLite_Android))]
namespace EatFood.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}