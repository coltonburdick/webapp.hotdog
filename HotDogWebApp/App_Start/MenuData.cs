using HotDogDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogWebApp.App_Start
{
    public static class MenuData
    {
        public static List<MenuItem> itemList = new List<MenuItem>()
        {
            // Mock Data.
            new ItemMeal("Hot Dog", 0.99),
            new ItemMeal("Hot Dog w/ Yellow Mustard", 1.49),
            new ItemMeal("Hot Dog w/ Spicy Brown Mustard", 1.49),
            new ItemMeal("The King Special with a Ton of Fucking Ketchup and Fucking Mustard", 5.00),
            new ItemMeal("Decked Out Hot Dog", 12.29),
            new ItemDrink("Spring Water", 0.49),
            new ItemDrink("Coca-Cola", 1.49),
            new ItemDrink("Sprite", 1.49),
            new ItemDrink("Hi-C Orange Lavaburst", 1.49),
            new ItemDrink("Coffee", 12.29),
            new ItemDrink("Ketchup Water", 0.04),
            new ItemSnack("Corn Dog", 0.74)
        };
    }
}
