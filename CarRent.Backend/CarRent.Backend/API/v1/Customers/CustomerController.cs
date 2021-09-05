using CarRent.Backend.Domain.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.API.v1.Customers
{
    [ApiController]
    [Route("[controller]/v1")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> logger;
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ILogger<CustomerController> logger, ICustomerRepository customerRepository)
        {
            this.logger = logger;
            this.customerRepository = customerRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(Guid id)
        {
            return customerRepository.Get(id);
        }

        [HttpPost]
        public ActionResult<Customer> CreateCustomer(CustomerPostDTO customer)
        {
            return customerRepository.Create(customer.Name, customer.Firstname, customer.City, customer.Street, customer.ZipCode);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            return customerRepository.GetAll().ToList();
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(Guid id)
        {
            customerRepository.Delete(id);
        }
    }
}
