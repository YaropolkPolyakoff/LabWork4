using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    interface IDocumentable
    {
        public void CreateDocument();
    }
    interface IEvacuatable
    {
        public void Evacuate();
    }
    interface IPerformable
    {
        public void Perform();
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract double Exp
        { get; }
        public double Age
        {
            get
            {
                DateTime today = DateTime.Today;

                if (BirthDate == null)
                {
                    throw new ArgumentException("Дата рождения неизвестно, введите данные вручную.");
                }
                int age = today.Year - BirthDate.Value.Year;
                if (BirthDate.Value.Date > today.AddYears(-age))
                    age--;
                return age;
            }
        }
        public DateTime? admisionDate;
        public DateTime? birthDate;
        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата рождения не может быть в будущем!");
                }
                if (BirthDate != null) { Console.WriteLine("Дата рождения уже заполнено!"); }
                else
                {
                    birthDate = value;
                }
            }
        }
        public DateTime? AdmisionDate
        {
            get { return admisionDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата регистрации не может быть в будущем!");
                }
                if (AdmisionDate != null) { Console.WriteLine("Дата регистрации уже заполнено!"); }
                else
                {
                    admisionDate = value;
                }
            }
        }
        public void AllBehavior()
        {
            working();
            talking();
            relaxing();
        }
        public abstract void working();
        public abstract void talking();
        public abstract void relaxing();
        public abstract void DisplayInfo();
    }
}
