using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace room
{
    public abstract class Room
    {
        public string Name { get; set; }
        public abstract void ReactToDayState(bool isStudyDay);
        public int Capacity { get; set; }
        public Room(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}
