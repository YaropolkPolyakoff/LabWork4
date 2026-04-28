using room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace computerClassRoom
{
    public class ComputerClassRoom : Room
    {
        public ComputerClassRoom(string name, int capacity) : base(name, capacity) { }
        public override void ReactToDayState(bool isStudyDay)
        {
            if (isStudyDay)
                Console.WriteLine($"Компьютерный класс {Name} открыт (вместимость {Capacity}).");
            else
                Console.WriteLine($"Компьютерный класс {Name} закрыт.");
        }
    }
}
