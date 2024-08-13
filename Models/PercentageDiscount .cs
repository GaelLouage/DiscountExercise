using DiscountSystem.Interfaces;

namespace DiscountSystem.Models
{
    public class PercentageDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            if (totalAmount <= 0) return 0;
            var discount = totalAmount * 0.10M;
            return totalAmount - discount;
        }
    }
}
