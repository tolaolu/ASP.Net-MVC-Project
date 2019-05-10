using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FastLearn.Models
{
    public class StudentLogin
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }


        /*  public class Registration
          {
              [Required]
              public string Name { get; set; }
              public string Email { get; set; }
              public string Address { get; set; }
              public string Phone { get; set; }
              public string Password { get; set; }
          }*/
    }
}