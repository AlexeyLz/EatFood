using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace EatFood
{
    public class FoodRepository
    {
        SQLiteConnection database;
        public FoodRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<FoodPlace>();
            
        }
        public IEnumerable<FoodPlace> GetItems()
        {
            return (from i in database.Table<FoodPlace>() select i).ToList();

        }
        public FoodPlace GetItem(int id)
        {
            return database.Get<FoodPlace>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<FoodPlace>(id);
        }
        public int SaveItem(FoodPlace item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
