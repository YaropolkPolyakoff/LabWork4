using computerClassRoom;
using lectureHall;
using person;
using professor;
using room;
using student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    public class University
    {
        public string Name { get; set; }
        private List<Room> rooms = new List<Room>();
        private List<Person> persons = new List<Person>();
        private List<Student> students = new List<Student>();
        private List<Professor> professors = new List<Professor>();
        public University(string name)
        {
            Name = name;
            ComputerClassRoom A453 = new ComputerClassRoom("Аудитория 453", 25);
            LectureHall A440 = new LectureHall("Аудитория 440", 100);
            AddRoom(A453);
            AddRoom(A440);
        }
        private void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        private void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }
        private void ChangeDayState(bool isStudyDay)
        {
            foreach (var room in rooms)
                room.ReactToDayState(isStudyDay);
        }
        public void StartStudyDay()
        {
            Console.WriteLine($"{Name}: Начался учебный день");
            ChangeDayState(true);
            foreach (var person in persons)
                person.working();
        }

        public void EndStudyDay()
        {
            Console.WriteLine($"{Name}: Учебный день завершен");
            ChangeDayState(false);
            foreach (var person in persons)
            { 
                person.talking(); 
                person.relaxing(); 
            }
        }
        public void DoWork()
        {
            foreach (var student in students)
            {
                cre
            }
            foreach (var professor in professors)
            {

            }
                
        }
    }
}
