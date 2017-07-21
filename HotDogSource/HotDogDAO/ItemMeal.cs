using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogDAO
{
    public class ItemMeal : MenuItem
    {
        // Constructor.
        public ItemMeal(string inName, double inPrice) : base(inName, inPrice)
        {
            ItemCat = "meal";
        }
    }
}
