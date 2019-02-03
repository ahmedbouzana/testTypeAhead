using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testTypeHead.Models
{
    public class Rental
    {
        public int Id { get; set; }


        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}