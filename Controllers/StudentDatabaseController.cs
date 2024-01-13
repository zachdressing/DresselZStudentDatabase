using DresselZStudentDatabase.Models;
using DresselZStudentDatabase.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace DresselZStudentDatabase.Controllers
{
    [Route("DBController")]
    public class StudentDatabaseController : ControllerBase
    {

        private readonly IStudentDatabaseService _studentdatabaseService;

        public StudentDatabaseController(IStudentDatabaseService studentDatabaseService)
        {
            _studentdatabaseService = studentDatabaseService;
        }

        [HttpGet] // use Get to get/pull data
        [Route("GetDBList")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
        public List<Student> GetStudents()
        {
            // Accessing the GetStudents() from our Interface
            return _studentdatabaseService.GetStudents();
        }

        [HttpPost] // use Post to add Data
        [Route("AddStudent/{firstName}/{lastName}/{studentHobby}")] // To pass data through Routes add /{parameter name}
        public List<Student> AddStudent(string firstName, string lastName, string studentHobby)
        {
            return _studentdatabaseService.AddStudent(firstName, lastName, studentHobby);
        }

        [HttpDelete] // use Delete to delete data - not really don't do this
        [Route("DeleteStudent/{firstName}/{lastName}")]
        public List<Student> DeleteStudent(string firstName, string lastName)
        {
            return _studentdatabaseService.DeleteStudent(firstName, lastName);
        }

    }
}