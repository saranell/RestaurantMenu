using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string itemName, double v, string description, string category, bool isNew)
        {
            ItemName = itemName;
            Description = description;
            Category = category;
            IsNew = IsNew;

        }
    }
}

