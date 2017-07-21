using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogDAO
{
    public class ItemDrink : MenuItem
    {
        // Constructor.
        public ItemDrink(string inName, double inPrice) : base(inName, inPrice)
        {
            ItemCat = "drink";
        }
    }
}
