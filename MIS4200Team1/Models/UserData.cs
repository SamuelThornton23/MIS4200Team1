using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team1.Models
{
    public class UserData
    {
        public Guid ID { get; set; }
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        public string lastName { get; set; }
        [DisplayName("Full Name")]
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string email { get; set; }
        [DisplayName("Business Unit")]
        [Required(ErrorMessage = "Business Unit is Required")]
        public string BusinessUnit { get; set; }
        [DisplayName("Hire Date")]
        [Required(ErrorMessage = "Hire Date is Required")]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true )]
        public DateTime HireDate { get; set; }
        public string Title { get; set; }
    }
}