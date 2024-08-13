using DiscountSystem.Interfaces;

namespace DiscountSystem.Models
{
    public class Order
    {
        public decimal TotalAmount { get; set; }    
        public IDiscount Discount { get; set; } 

        public void ApplyDiscount(IDiscount disCount)
        {
           TotalAmount = disCount.ApplyDiscount(TotalAmount);
        }
    }
}
