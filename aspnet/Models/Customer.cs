using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace aspnet.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Birthdate")]
        [MinYearsIfAMember]
        public DateTime? Birthday { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }
        
        [Display(Name = "Mebership Type")]
        public byte MembershipTypeId { get; set; }
    }
}