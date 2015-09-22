using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC5_Practice.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name.")]
        public string Name { get; set; }
        public bool IsMarried { get; set; }
        [Required(ErrorMessage = "Please Select Gender")]
        public int Gender { get; set; }
    }
}