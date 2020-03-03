namespace todolist.Models
{

    public class Item
    {
        public string Description { get; }

        public Item() { }
        public Item(string description)
        {
            Description = description;
        }
    }
}