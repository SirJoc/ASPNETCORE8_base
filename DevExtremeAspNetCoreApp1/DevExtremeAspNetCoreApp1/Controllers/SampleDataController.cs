using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtremeAspNetCoreApp1.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreApp1.Controllers {
    

    [Route("api/[controller]")]
    public class SampleDataController : Controller {
        private readonly AppDbContext dbContext;
        public SampleDataController(AppDbContext _context) 
        { 
            dbContext = _context;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            Index();
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

        [HttpGet("/hello")]
        public string GetHello()
        {
            return "hola";
        }

        public IActionResult Index()
        {
            var emp = new Employee();
            emp.Email = "hola@gmail.com";
            emp.Name = "Hola Como Estas";

            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();

            var employees = dbContext.Employees.ToArray();
            return View();
        }
    }
}