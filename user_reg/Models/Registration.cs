using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace user_reg.Models
{
    public class Registration
    {
        [Key]
        public int UserId { get; set; }
       


        [Required(ErrorMessage ="Please enter User Name")]       
        [Display(Name="User Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        

        [Required(ErrorMessage = "Please enter Age")]       
        [Display(Name = "Age")]
        [Column(TypeName = "int")]
        public int Age { get; set; }
        

        [Required(ErrorMessage = "Please enter Phone Number")]       
        [Display(Name = "Phone Number")]
        [Column(TypeName = "nvarchar(10)")]
        public string PhoneNum { get; set; }
       

        [Required(ErrorMessage = "Please enter Email..")]
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
