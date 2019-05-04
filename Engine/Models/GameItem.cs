﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        private int _itemTypeID;
        private string _name;
        private int _price;

        public int ItemTypeID { get => _itemTypeID; set => _itemTypeID = value; }
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public GameItem(int itemTypeID, string name, int price)
        {
            this.ItemTypeID = itemTypeID;
            this.Name = name;
            this.Price = price;
        }
    }
}