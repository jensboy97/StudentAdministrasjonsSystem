namespace StudentAdministrasjonsSystem;

public class Subject
{
    public string SubjectCode { get; private set; }
    public string SubjectName;
    private int _numberOfStudyPoints;

    public Subject(string subjectCode, string subjectName, int numberOfStudyPoints)
    {
        SubjectCode = subjectCode;
        SubjectName = subjectName;
        _numberOfStudyPoints = numberOfStudyPoints;
    }

    public void printSubject()
    {
        Console.WriteLine($"Code: {SubjectCode} Subject: {SubjectName}, Points: {_numberOfStudyPoints}");
        Console.WriteLine();
    }
}