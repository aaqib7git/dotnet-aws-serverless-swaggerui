﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// <summary>
        /// Get All Customer Details.
        /// </summary>
        /// <returns> Return Customer Details</returns>
        /// <response code="200">Return Customer Details successfully.</response>
        /// <response code="500">There was a problem getting customer details due to an internal error with an API.</response>
        [HttpGet]
        public ActionResult<Customer> Get()
        {
            return new OkObjectResult(new Customer()
            {
                Name = "John",
                Age = 30
            });
        }

        /// <summary>
        /// Create Customer given Name and Age.
        /// </summary>
        /// <param name="customer">Customer details object - Name and Age is required.</param>
        /// <returns></returns>
        /// <response code="200">Create Customer sucessfully.</response>
        /// <response code="500">There was a problem creating customer details due to an internal error with an API.</response>
        [HttpPost]
        public ActionResult Create([FromBody] Customer customer)
        {
            return new OkObjectResult("Customer Created");
        }
    }

    public class Customer
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}