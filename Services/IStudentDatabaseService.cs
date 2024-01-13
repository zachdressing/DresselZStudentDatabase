using DresselZStudentDatabase.Models;

namespace DresselZStudentDatabase.Services.Students;

public interface IStudentDatabaseService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string firstName, string lastName, string studentHobby);
    List<Student> DeleteStudent(string firstName, string lastName);
}