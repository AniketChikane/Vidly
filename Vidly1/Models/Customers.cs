using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly1.Models
{
    public class Customers
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="PLZ Enter customers name")]
        [StringLength(255)]
        public String Name { get; set; }
        
        public bool IsSubscribedNewsLetter { get; set; }
       
        public MembershipType MembershipType { get; set; }
        [Display(Name ="Membership Type")]
        
        public byte MembershipTypeId { get; set; }

       
        [Display(Name ="Date Of Birth")]
        [Min18YearifAMember]
        public DateTime? Birthdate { get; set; }

    }
}