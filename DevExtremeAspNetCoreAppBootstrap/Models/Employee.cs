using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DevExtremeAspNetCoreAppBootstrap.Models {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
