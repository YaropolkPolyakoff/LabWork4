using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person;

namespace professor
{
    public class Professor : Person, IDocumentable, IEvacuatable, IPerformable
    {
        public override double Exp
        {
            get
            {
                DateTime today = DateTime.Today;
                double exp = today.Year - AdmisionDate.Value.Year;
                return exp;
            }
        }
        public Professor(string name, DateTime admisionDate)
        {
            Name = name;
            AdmisionDate = admisionDate;
            BirthDate = null;
        }
        public Professor(string name, DateTime birthDate, DateTime admisionDate)
        {
            Name = name;
            BirthDate = birthDate;
            AdmisionDate = admisionDate;
        }
        public override void working()
        {
            string ACT = $"Преподователь " + Name + " работает на парах.";
            Console.WriteLine(ACT);
        }
        public override void talking()
        {
            string ACT = $"Преподователь " + Name + " общается в университете.";
            Console.WriteLine(ACT);
        }
        public override void relaxing()
        {
            string ACT = $"Преподователь " + Name + " отдыхает.";
            Console.WriteLine(ACT);
        }
        public void CreateDocument()
        {
            Console.WriteLine($"Преподаватель {Name} создает документ бережно с перепроверкой");
        }
        public void Evacuate()
        {
            Console.WriteLine($"Преподаватель {Name} организует эвакуацию студентов");
        }
        public void Perform()
        {
            Console.WriteLine($"Преподаватель {Name} участвует в юбилее университета и произносит речь");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Дата рождения: {BirthDate:dd.MM.yyyy}");
            Console.WriteLine($"Начало деятельности: {AdmisionDate:dd.MM.yyyy}");
            Console.WriteLine($"Опыт: {Exp} лет.");
        }
    }
}
