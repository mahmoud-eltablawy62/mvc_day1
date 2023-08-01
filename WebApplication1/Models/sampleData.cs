using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace WebApplication1.Models
{
    public class sampleData
    {
        public static List<employee> employees { get; set; }

        static sampleData()
        {
            employees = new List<employee>()
            {
                new employee() { Id =1 , Name="mahmoud" , Age =50, Salary =50 , Address ="street1", Email = "mahmoudeltablawy702@gmail.com" },
                new employee() { Id =2 ,Name ="Ahmed" , Age = 50, Salary=50 ,Address="street2",Email = "7oda@gmail.com"}
            };
        }
    }
}
