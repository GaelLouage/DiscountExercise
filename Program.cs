using DiscountSystem.Models;
using System.Security.Cryptography.Xml;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var orders = new List<Order>()
{
    new Order() 
    { 
        TotalAmount = 55, 
        Discount = new FixedAmountDiscount(),
    },
     new Order()
     {
        TotalAmount = 55,
         Discount = new PercentageDiscount(),
    },
};
app.MapGet("/", () => 
{
    orders.ForEach(x => x.ApplyDiscount(x.Discount));
    return orders;
    
});

app.Run();
