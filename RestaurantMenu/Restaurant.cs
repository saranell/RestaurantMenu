using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Restaurant
    {
        static void Main (string[] args)
        {

        MenuItem hummus = new MenuItem("Hummus Plate", "A blend of chickpeas, tahini, garlic, lemon juice, and olive oil. Served with Arabic bread.", "Appetizers", 7.99, false);
        MenuItem falafel = new MenuItem("Falafel", "4 deep-fried patties made with chickpeas, garlic, and spices. Served with a side of tahini sauce.", "Appetizers", 6.99, false);
        MenuItem babaGanoush = new MenuItem("Baba Ganoush", "Pureed roasted eggplant with lemon juice, garlic, and olive oil. Served with Arabic bread.", "Appetizers", 7.99, true);
        MenuItem lentilSoup = new MenuItem("Lentil Soup", "Creamy lentils, onion, and spices.", "Soups & Salads", 3.99, false);
        MenuItem tabbouleh = new MenuItem("Tabbouleh", "Bulgar wheat cooked with tomatoes, green onion, parsley, lemon juice, and olive oil.", "Soups & Salads", 3.99, true);
        MenuItem kabob = new MenuItem("Kabob", "Seasoned vegetables grilled and skewered with choice of spiced beef, lamb, or tofu.", "Entrees", 17.99, true);
        MenuItem schwarma = new MenuItem("Schwarma", "Choice of grilled beef, lamb, or potatoes served on bed of rice blended with spices.", "Entrees", 19.99, false);
        MenuItem eggplant = new MenuItem("Moussaka", "Baked eggplant, tomatoes, onions, garlic and spices.", "Entrees", 15.99, false);
        MenuItem baklava = new MenuItem("Baklava", "Pastry made of phyllo dough layered with chopped walnuts and cinnamon, soaked in rosewater syrup.", "Desserts", 5.99, false);


        DateTime today = DateTime.Now;
        List<MenuItem> startingMenu = new List<MenuItem>();

        Menu ourMenu = new Menu(today, startingMenu);

        ourMenu.AddItem(hummus);
        ourMenu.AddItem(falafel);
        ourMenu.AddItem(babaGanoush);

        ourMenu.PrintMenu();

        ourMenu.PrintItem(lentilSoup);

        ourMenu.RemoveItem(tabbouleh);

        ourMenu.PrintMenu();
        }
    }
}