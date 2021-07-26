using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace EatFood
{
    [Table("FoodPlaces")]



   


    public class FoodPlace
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
       public int Id { get; set; }

       public string name { get; set; }

       public string midPrice { get; set; }
        
       public string type { get; set; }
       
       public string typicalFood { get; set; }
         
        public string rating { get; set; }

        public string adress { get; set; }

      //  public Image image { get; set; }

        

        public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }

        public interface IEnumerator
        {
            bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
            object Current { get; }  // текущий элемент в контейнере
            void Reset(); // перемещение в начало контейнера
        }


    }

    
}
