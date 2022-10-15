using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.data;
using Pizzeria.Models;

namespace Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext _context;
        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = ImageTitle;
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
