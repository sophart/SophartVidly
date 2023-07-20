﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SophartVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [ForeignKey(nameof(MembershipType))]
        public int MembershipTypeId { get; set; }

        public MembershipType MembershipType { get; set; }
    }
}