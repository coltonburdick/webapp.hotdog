using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogDAO
{
    public class MenuItem
    {
        // Variables.
        private String itemName;
        private double itemPrice;
        private String itemCat;

        // Constructor.
        public MenuItem(String inName, double inPrice)
        {
            this.itemName = inName;
            this.itemPrice = inPrice;
        }

        #region Properties.
        // Item name.
        public String ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        // Item price.
        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        // Item category.
        public String ItemCat
        {
            get { return itemCat; }
            set { itemCat = value; }
        }
        #endregion Properties.

        // ToString.
        public override string ToString()
        {
            return ($"Item '{itemName}' priced at ${itemPrice} in category {itemCat}.");
        }
    }
}