using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogDAO
{
    public class ItemSnack : MenuItem
    {
        // Constructor.
        public ItemSnack(string inName, double inPrice) : base(inName, inPrice)
        {
            ItemCat = "snack";
        }
    }
}
