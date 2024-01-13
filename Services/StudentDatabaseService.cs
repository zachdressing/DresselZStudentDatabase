using DresselZStudentDatabase.Data;
using DresselZStudentDatabase.Models;
using DresselZStudentDatabase.Services.Students;

namespace DresselZStudentDatabase.Services.StudentDatabase;

public class StudentDatabaseService : IStudentDatabaseService
{
    private readonly DataContext _db;
    public List<string> studentList = new();

    public StudentDatabaseService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstName, string lastName, string studentHobby)
    {
        Student newStudent = new();
        newStudent.firstName = firstName;
        newStudent.lastName = lastName;
        newStudent.hobby = studentHobby;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstName, string lastName)
    {
        var student = _db.Students.FirstOrDefault(fileStudent => fileStudent.firstName == firstName && fileStudent.lastName == lastName);
        if (student != null)
        {
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }
}