// See https://aka.ms/new-console-template for more information

namespace StudentAdministrasjonsSystem;

class program
{
    static void Main(string[] args)
    {
        var Subject = new Subjects();
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student("Ola", 23, "Administrasjon", 0004566 ));
     var student1 = new Student("Ola", 23,"Administrasjon", 0004566);
     var student2 = new Student("Jenny", 22, "Administrasjon og bærekraftig drift", 0004567);
     var subject1 = new Subject("AKT2004", "Math", 10);
     var subject2 = new Subject("SSH2002", "Administrasjon og bærekraftig drift", 10);
     var grades1 = new Grades(student1, subject1, 3);
     var grades2 = new Grades(student2, subject2, 5);
     
    student1.addSubjects(Subject.subjectsReturn("Nor1018"));
    student1.printStudent();
    // student2.printStudent();
    // subject1.printSubject();
    // subject2.printSubject();
    // grades1.printGrades();
    // grades2.printGrades();
    
    }
    
}

