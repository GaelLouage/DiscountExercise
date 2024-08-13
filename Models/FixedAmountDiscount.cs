using DiscountSystem.Interfaces;

namespace DiscountSystem.Models
{
    public class FixedAmountDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount <= 0 ? 0 : totalAmount - 20;
        }
    }
}
