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
    public class NewRentalsController : ApiController
    {
        private WebAppContext _context = new WebAppContext();

       protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(Rental newRental)
        {
            

                

            return Ok();
        }
    }
}