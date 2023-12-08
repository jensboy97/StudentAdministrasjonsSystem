namespace StudentAdministrasjonsSystem;

public class Student
{
    public string Name;
    private int _age;
    private string _studyProgram;
    private int _studentId;
    private List<Subject> subjectList = new List<Subject>();
    public Student(string name, int age, string studyProgram, int studentId)
    {
        Name = name;
        _age = age;
        _studyProgram = studyProgram;
        _studentId = studentId;
    }

    public void addSubjects(Subject subject)
    {
        subjectList.Add(subject);
    }
    public void printStudent()
    {
        Console.WriteLine($"Id: {_studentId}  Name: {Name}  Age: {_age}  Study: {_studyProgram}");
        foreach (var subject in subjectList)
        {
         Console.WriteLine(subject.SubjectName);   
        }
    }
   
    
}