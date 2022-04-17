using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreAppBootstrap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreAppBootstrap.Controllers
{
    [Route("api/[controller]/[action]/")]
    public class EmployeeGridController : Controller
    {
        private readonly EmployeeDbContext _context;
        public EmployeeGridController(EmployeeDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.EmployeesTable, loadOptions);
        }


        [HttpPost]
        public IActionResult InsertEmployee(string values)
        {
            var newEmployee = new Employee();
            JsonConvert.PopulateObject(values, newEmployee);

            if(!TryValidateModel(newEmployee))
            {
                return BadRequest();
            }

            _context.EmployeesTable.Add(newEmployee);
            _context.SaveChanges();

            return Ok(newEmployee);
        }


        [HttpPut]
        public IActionResult UpdateEmployee(int key, string values)
        {
            var employee = _context.EmployeesTable.FirstOrDefault(o => o.Id == key);
            JsonConvert.PopulateObject(values, employee);

            if (!TryValidateModel(employee))
            {
                return BadRequest();
            }

            _context.SaveChanges();

            return Ok(employee);
        }



        [HttpDelete]
        public void DeleteEmployee(string key)
        {
            var employee = _context.EmployeesTable.FirstOrDefault(e => e.Id == Int32.Parse(key));
            _context.EmployeesTable.Remove(employee);
            _context.SaveChanges();
        }
    }

}

