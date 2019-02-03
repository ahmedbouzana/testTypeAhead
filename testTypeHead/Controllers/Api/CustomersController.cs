using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using testTypeHead;
using testTypeHead.Models;

namespace testTypeHead.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private WebAppContext db = new WebAppContext();

        // Get /api/customers
        public IHttpActionResult GetCustomers(string query)
        {
            var customersQuery = db.Customers.Where(c => c.Name.Contains(query));

            var customerDtos = customersQuery
                .ToList();
                //.Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }
    }
}