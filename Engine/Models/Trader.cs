using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Trader : LivingEntity
    {
        public Trader(string name) : base(name, 99999, 99999, 99999)
        {
        }
    }
}
