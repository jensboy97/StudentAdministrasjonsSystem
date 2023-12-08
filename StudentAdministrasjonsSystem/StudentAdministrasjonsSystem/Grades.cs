namespace StudentAdministrasjonsSystem;

public class Grades
{
    private Student _student;
    private Subject _subject;
    private int _gradeValue;

    public Grades(Student student,Subject subject, int gradeValue)
    {
        _student = student;
        _subject = subject;
        _gradeValue = gradeValue;
    }

    public void printGrades()
    {
        Console.WriteLine($"Student: {_student.Name} Subject: {_subject.SubjectName} Grade: {_gradeValue}");
        Console.WriteLine();
    }
}