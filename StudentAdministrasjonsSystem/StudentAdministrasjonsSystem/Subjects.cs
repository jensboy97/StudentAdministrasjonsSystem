namespace StudentAdministrasjonsSystem;

public class Subjects
{
    private List<Subject> SubjectList = new List<Subject>();

    public Subjects()
    {
        SubjectList.Add(new Subject("Mat1011", "Matte", 10));
        SubjectList.Add(new Subject("Gy1012", "Gym", 10));
        SubjectList.Add(new Subject("Eng1014", "Engelsk", 10));
        SubjectList.Add(new Subject("Nor1018", "Norsk", 10));
    }

    public Subject subjectsReturn(string subjectCode)
    {
        return SubjectList.Find(subject => subject.SubjectCode == subjectCode);
    }
}