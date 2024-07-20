using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
     StudentMockData sd=new StudentMockData();  
     public IActionResult GetSTBYTD(int id)
     {
      Student student = sd.GetById(id);
      return View("student",student);
     }
     public IActionResult GetALL(int id) 
     {
      List<Student> Lsd=sd.GetALL();
      return View("students",Lsd);
     }
    }
}
