using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class employeeController : Controller
    {
        
            public IActionResult GETID(int id)
            {
                employee? Employee = sampleData.employees.Where(s => s.Id == id).SingleOrDefault();
                if (Employee == null)
                {
                    return Content("employee is not available.");
                }
                return View("GetID", Employee);
            }

            public IActionResult GETALL()
            {
                List<employee> employees = sampleData.employees;
                return View("GetAll",employees);
                
            }
    }
    
}
