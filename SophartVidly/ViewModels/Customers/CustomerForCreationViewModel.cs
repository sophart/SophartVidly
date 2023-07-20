using SophartVidly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SophartVidly.ViewModels.Customers
{
    public class CustomerForCreationViewModel
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Subscribe to Newsletter?")]
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; } = new List<MembershipType>();
    }
}