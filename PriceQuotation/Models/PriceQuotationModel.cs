using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter the SubTotal amount.")]
        [Range(1, 5000, ErrorMessage =
                    "SubTotal amount must be between 1 and 5000.")]
        public decimal? SubTotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount amount.")]
        [Range(1, 100, ErrorMessage =
                    "Discount amount must be between 1 and 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal? CalculateDiscountAmount()
        {
            decimal? discountAmount = DiscountPercent * SubTotal / 100;
            return discountAmount;
        }
        public decimal? CalculateTotal()
        {
            decimal? total = SubTotal - CalculateDiscountAmount();
            return total;
        }

    }
}
