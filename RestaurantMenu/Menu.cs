using System;
namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public string DateTime { get; set; }

        public Menu(List<MenuItem> items, string dateTime)
        {
            Items = items;
            DateTime = dateTime;
        }
    }
}

