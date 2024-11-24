using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {

        Students[] students = new Students[]
        {
            new Students { MSSV = 23521828, Name = "Lê Thị Tường Vy" },
            new Students { MSSV = 23451837, Name = "Trần Ngọc Thúy Vy" },
        };

        public IEnumerable<Students> GetAllStudents()
        {
            return students;
        }
    }
}
