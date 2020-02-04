using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EvolentHealth.Models
{
    public class Contact
    {
        public int Id { get; set;}
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName {get; set;}
        public string Email { get; set; }
        public double PhoneNumber { get; set; }
        public string Status { get; set; }
    }
}