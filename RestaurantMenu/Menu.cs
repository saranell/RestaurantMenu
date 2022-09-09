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
        public List<MenuItem> AddItem (MenuItem item)
        {
            Items.Add(item);
            return Items;
        }

        public List<MenuItem> RemoveItem (MenuItem item)
        {
            //public List<MenuItem> menuItems = new List<MenuItem>();
            int toBeRemoved = -1;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name.Equals(item.Name))
                {
                    toBeRemoved = i;
                    Items.RemoveAt(toBeRemoved);
                }
            }

            return Items;
        }

        public string MenuUpdated()
        {
            return "Menu last updated on " + LastUpdated;
        }

        public void PrintMenuItem(MenuItem item)
        {
            Console.WriteLine($"{item.Name}\n${item.Description}\n${item.Price}");
        }

        public void PrintMenu()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine(Items[i].Description);
            }
        }
    }
}


