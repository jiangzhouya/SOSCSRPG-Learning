using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon :GameItem
    {
        private int _minimumDamage;
        private int _maximumDamage;

        public int MinimumDamage { get => _minimumDamage; set => _minimumDamage = value; }
        public int MaximumDamage { get => _maximumDamage; set => _maximumDamage = value; }

        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage):base(itemTypeID,name,price,true)
        {
            this.MinimumDamage= minDamage;
            this.MaximumDamage = maxDamage;
        }
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name,Price, MinimumDamage, MaximumDamage);
        }
    }
}
