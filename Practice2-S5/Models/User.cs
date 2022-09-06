using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice2_S5.Models
{
    public class User
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter your Name.")]
        [StringLength(20, MinimumLength = 6)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Password.")]
        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your Reenter Password.")]
        [StringLength(20, MinimumLength = 5)]
        [Compare("Password", ErrorMessage = "The specified passwords do not match with the Password field.")]
        public string ReenterPassword { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
    }
}