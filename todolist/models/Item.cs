using System.Collections.Generic;

namespace todolist.Models
{

    public class Item
    {

        public string Description { get; set; }
        public static List<Item> _instances = new List<Item>();
        public Item() { }
        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
        }
        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}