using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Player
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;
        public string Name { get => _name; set => _name = value; }
        public string CharacterClass { get => _characterClass; set => _characterClass = value; }
        public int HitPoints { get => _hitPoints; set => _hitPoints = value; }
        public int ExperiencePoints { get => _experiencePoints; set => _experiencePoints = value; }
        public int Level { get => _level; set => _level = value; }
        public int Gold { get => _gold; set => _gold = value; }
    }
}
