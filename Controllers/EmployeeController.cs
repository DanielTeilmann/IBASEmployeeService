namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>()
            {
                
                new Employee()
                {
                    Id = "21",
                    Name = "Mette Bangsbo",
                    Email = "meba@ibas.dk",
                    Age = 34,
                    Department = new Department()
                    {
                        Id = 1,
                        Name = "Salg"
                    }
                },
                new Employee()
                {
                    Id = "22",
                    Name = "Hans Merkel",
                    Email = "hame@ibas.dk",
                    Age = 45,
                    Department = new Department()
                    {
                        Id = 2,
                        Name = "Support"
                    }
                },
                new Employee()
                {
                    Id = "23",
                    Name = "Karsten Mikkelsen",
                    Email = "kami@ibas.dk",
                    Age = 29,
                    Department = new Department()
                    {
                        Id = 2,
                        Name = "Support"
                    }
                },
                new Employee()
                {
                    Id = "24",
                    Name = "Peter Jensen",
                    Email = "peje@ibas.dk",
                    Age = 31,
                    Department = new Department()
                    {
                        Id = 3,
                        Name = "IT"
                    }
                },
                new Employee()
                {
                    Id = "25",
                    Name = "Sofie Nielsen",
                    Email = "soni@ibas.dk",
                    Age = 26,
                    Department = new Department()
                    {
                        Id = 3,
                        Name = "IT"
                    }
                },
                new Employee()
                {
                    Id = "26",
                    Name = "Martin Hansen",
                    Email = "maha@ibas.dk",
                    Age = 38,
                    Department = new Department()
                    {
                        Id = 3,
                        Name = "IT"
                    }
                },
                new Employee()
                {
                    Id = "27",
                    Name = "Lise Andersen",
                    Email = "lian@ibas.dk",
                    Age = 42,
                    Department = new Department()
                    {
                        Id = 4,
                        Name = "Kantinen"
                    }
                },
                new Employee()
                {
                    Id = "28",
                    Name = "Thomas Larsen",
                    Email = "thla@ibas.dk",
                    Age = 23,
                    Department = new Department()
                    {
                        Id = 4,
                        Name = "Kantinen"
                    }
                }
            };

            return employees;
        }

        
        [HttpGet("GetDepartment/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetDepartment(int departmentId)
        {
            var employees = Get();
            var foundEmployee = employees.Where(e => e.Department.Id == departmentId);
            if (!foundEmployee.Any())
            {
                return NotFound();
            }
            return Ok(foundEmployee);
        }
    }
}