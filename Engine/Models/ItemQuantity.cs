using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity
    {
        private int _itemID;
        private int _quantity;

        public int ItemID { get => _itemID; set => _itemID = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public ItemQuantity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
