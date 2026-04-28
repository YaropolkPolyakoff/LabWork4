using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person;

namespace librarian
{
    public class Librarian : Person, IPerformable
    {
        public override double Exp
        {
            get
            {
                TimeSpan timeSpan = (TimeSpan)(DateTime.Today - AdmisionDate);
                double exp = Math.Ceiling(timeSpan.TotalDays / 30);
                return exp;
            }
        }
        public Librarian(string name, DateTime admisionDate)
        {
            Name = name;
            AdmisionDate = admisionDate;
            BirthDate = null;
        }
        public Librarian(string name, DateTime birthDate, DateTime admisionDate)
        {
            Name = name;
            BirthDate = birthDate;
            AdmisionDate = admisionDate;
        }
        public override void working()
        {
            string ACT = $"Библиотекарь " + Name + " работает в библиотеке университета.";
            Console.WriteLine(ACT);
        }
        public override void talking()
        {
            string ACT = $"Библиотекарь " + Name + " общается в университете.";
            Console.WriteLine(ACT);
        }
        public override void relaxing()
        {
            string ACT = $"Библиотекарь " + Name + " отдыхает.";
            Console.WriteLine(ACT);
        }
        public void Perform()
        {
            Console.WriteLine($"Библиотекарь {Name} участвует в юбилее университета и организует книжную выставку");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Дата рождения: {BirthDate:dd.MM.yyyy}");
            Console.WriteLine($"Начало деятельности: {AdmisionDate:dd.MM.yyyy}");
            Console.WriteLine($"Опыт: {Exp} месяцев.");
        }
    }
}
