using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVcdemo.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Compare("Email")]
        public string RetypeEmail { get; set; }
        [DisplayName("Mobile Number")]
        public string Phone { get; set; }
        [RegularExpression("^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$")]
        [Required]
        public string Snic { get; set; }
        [Range(18, 25)]
        public string Age { get; set; }
        [StringLength(35)]
        public string City { get; set; }
        public string Address { get; set; }
        [Required]
        public DateTime? DateTime { get; set; }

    }
}