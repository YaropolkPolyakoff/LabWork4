using student;
using professor;
using librarian;
using securityMemberOrCafeteriaWorker;
using university;
using computerClassRoom;
using lectureHall;

University university = new University("Сибирский госудраственный университет путей сообщения (СГУПС)");

Student student1 = new Student("Ярослав", new DateTime(2023, 09, 01));
student1.BirthDate = new DateTime(2005, 10, 08);
university.AddPerson(student1);
Student student2 = new Student("Иван", new DateTime(1990, 09, 03), new DateTime(2004, 01, 15));
university.AddPerson(student2);

Professor professor1 = new Professor("Василий", new DateTime(2021, 04, 02));
professor1.BirthDate = new DateTime(1984, 12, 12);
university.AddPerson(professor1);
Professor professor2 = new Professor("Аркадий", new DateTime(1970, 02, 03), new DateTime(1990, 02, 10));
university.AddPerson(professor2);

Librarian librarian1 = new Librarian("Елизавета", new DateTime(2021, 04, 02));
librarian1.BirthDate = new DateTime(1996, 06, 05);
university.AddPerson(librarian1);
Librarian librarian2 = new Librarian("Катерина", new DateTime(1973, 09, 01), new DateTime(1990, 03, 11));
university.AddPerson(librarian2);

SecurityMemberOrCafeteriaWorker SecurityMemberOrCafeteriaWorker1 = new SecurityMemberOrCafeteriaWorker("Елизавета", new DateTime(2021, 04, 02));
SecurityMemberOrCafeteriaWorker1.BirthDate = new DateTime(1989, 1, 13);
university.AddPerson(SecurityMemberOrCafeteriaWorker1);
SecurityMemberOrCafeteriaWorker SecurityMemberOrCafeteriaWorker2 = new SecurityMemberOrCafeteriaWorker("Катерина", new DateTime(1971, 10, 01), new DateTime(1990, 03, 20));
university.AddPerson(SecurityMemberOrCafeteriaWorker2);

university.StartStudyDay();
university.EndStudyDay();
Console.ReadKey();
