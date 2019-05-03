using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        int _xCoordinate;
        int _yCoordinate;
        string _name;
        string _description;
        string _imageName;
        public int XCoordinate { get => _xCoordinate; set => _xCoordinate = value; }
        public int YCoordinate { get => _yCoordinate; set => _yCoordinate = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string ImageName { get => _imageName; set => _imageName = value; }
    }
}
