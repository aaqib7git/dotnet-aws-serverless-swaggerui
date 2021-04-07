using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerAPILambda.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        [HttpGet]
        public ActionResult<Customer> Get()
        {
            return new OkObjectResult(new Customer()
            {
                Name = "John",
                Age = 30
            });
        }

        [HttpPost]
        public ActionResult Create()
        {
            return new OkObjectResult("Customer Created");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}