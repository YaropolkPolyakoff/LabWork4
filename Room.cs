using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person;

namespace room
{
    public abstract class Room : IEvacuatable
    {
        public string Name { get; set; }
        public abstract void ReactToDayState(bool isStudyDay);
        public abstract void Evacuate();
        public int Capacity { get; set; }
        public Room(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}
