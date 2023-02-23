using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NGUYENVANVUONGBTH.Models;

namespace NGUYENVANVUONGBTH.Controllers;

    public class EmployeeController : Controller 
    {
        public IActionResult Index()
    {
        return View();
    }
    }