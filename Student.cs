using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using person;
using document;

namespace student
{

    public class Student : Person
    {
        public override double Exp 
        {
            get 
            {
                TimeSpan timeSpan = (TimeSpan)(DateTime.Today - AdmisionDate);
                double exp = Math.Ceiling(timeSpan.TotalDays / 180);
                return exp;
            }
        }
        public Student(string name, DateTime admisionDate)
        {
            Name = name;
            AdmisionDate = admisionDate;
            BirthDate = null;
        }
        public Student(string name, DateTime birthDate, DateTime admisionDate)
        {
            Name = name;
            BirthDate = birthDate;
            AdmisionDate = admisionDate;
        }
        public override void working()
        {
            string ACT = $"Студент " + Name + " учиться на парах.";
            Console.WriteLine(ACT);
        }
        public override void talking()
        {
            string ACT = $"Студент " + Name + " общается в университете.";
            Console.WriteLine(ACT);
        }
        public override void relaxing()
        {
            string ACT = $"Студент " + Name + " отдыхает.";
            Console.WriteLine(ACT);
        }
        public void CreateDocument()
        {
            Console.WriteLine($"Студент {Name} создает документ быстро без перепроверки");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Дата рождения: {BirthDate:dd.MM.yyyy}");
            Console.WriteLine($"Начало деятельности: {AdmisionDate:dd.MM.yyyy}");
            Console.WriteLine($"Опыт: {Exp} семестров.");
        }
    }
}
