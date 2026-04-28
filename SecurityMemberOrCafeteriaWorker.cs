using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person;

namespace securityMemberOrCafeteriaWorker
{
    public class SecurityMemberOrCafeteriaWorker : Person
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
        public SecurityMemberOrCafeteriaWorker(string name, DateTime admisionDate)
        {
            Name = name;
            AdmisionDate = admisionDate;
            BirthDate = null;
        }
        public SecurityMemberOrCafeteriaWorker(string name, DateTime birthDate, DateTime admisionDate)
        {
            Name = name;
            BirthDate = birthDate;
            AdmisionDate = admisionDate;
        }
        public override void working()
        {
            string ACT = $"Работник службы безопасности/столовой " + Name + " на смене в университете.";
            Console.WriteLine(ACT);
        }
        public override void talking()
        {
            string ACT = $"Работник службы безопасности/столовой " + Name + " общается в университете.";
            Console.WriteLine(ACT);
        }
        public override void relaxing()
        {
            string ACT = $"Работник службы безопасности/столовой " + Name + " отдыхает.";
            Console.WriteLine(ACT);
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
