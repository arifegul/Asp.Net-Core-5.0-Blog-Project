using BlogProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass 
            {
                categoryName= "Teknoloji", 
                categoryCount=10 
            });
            list.Add(new CategoryClass
            {
                categoryName = "Yazılım",
                categoryCount = 7
            });
            list.Add(new CategoryClass
            {
                categoryName = "Bilim",
                categoryCount = 12
            });
            list.Add(new CategoryClass
            {
                categoryName = "Girişim",
                categoryCount = 5
            });
            return Json(new { jsonlist = list });
        }
    }
}
