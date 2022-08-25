using System;
namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated{ get; set; }

        public Menu(List<MenuItem> item, DateTime lastUpdated)
        {
            Items = item;
            LastUpdated = lastUpdated;
        }
        public void PrintMenuItem(MenuItem item)
        {
            Console.WriteLine($"{item.Name}\n${item.Description}\n${item.Price}");

            if (item.IsNew)
            {
                Console.WriteLine("New item!");
            }
        }
        public List<MenuItem> AddToMenu (MenuItem item)
        {
            Items.Add(item);
            return Items;
        }
    }
}

