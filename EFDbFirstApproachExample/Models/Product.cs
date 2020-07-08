using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFDbFirstApproachExample.CustomValidations;

namespace EFDbFirstApproachExample.Models
{
    public class Product
    {
        [Key]
        public long ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required (ErrorMessage ="Product Name can not be blank")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Price  can not be blank")]
        [DivisibleBy10Attribute(ErrorMessage = "Price should be in multiples of 10")]
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public string AvailabilityStatus { get; set; }


        [Display(Name ="Category Type")]
        public Nullable<long> CategoryID { get; set; }

        [Display(Name = "Brand Type")]
        public Nullable<long> BrandID { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Photo { get; set; }
        public Nullable <decimal> Quantity { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}


