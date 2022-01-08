using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_MPD.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Product name")]
        public string Name { get; set; }
        public string Brand { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:P2}")]
        public decimal Discount { get; set; }
        private decimal _discountedPrice;
        private object ViewData;
        [Display(Name = "Discounted price")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        public decimal DiscountedPrice
        { 
            get
            {
                return Price - Price * Discount;
            }
            set
            {
                _discountedPrice = value;
            }
        }
        [Display(Name = "Available on")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:D}")]
        public DateTime DiscountUntill { get; set; }
        public int RetailerID { get; set; }
        public Retailer Retailer { get; set; }
        
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
