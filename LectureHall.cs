using room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lectureHall
{
    public class LectureHall : Room
    {
        public LectureHall(string name, int capacity) : base(name, capacity) { }
        public override void ReactToDayState(bool isStudyDay)
        {
            if (isStudyDay)
                Console.WriteLine($"Лекционная аудитория {Name} открыта (вместимость {Capacity}).");
            else
                Console.WriteLine($"Лекционная аудитория {Name} закрыта.");
        }
        public override void Evacuate()
        {
            Console.WriteLine($"Лекционная аудитория {Name}: включена табличка ВЫХОД");
        }
    }
}
