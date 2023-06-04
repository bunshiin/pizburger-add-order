
using Microsoft.AspNetCore.Mvc;
using pizburger.Entities;
using pizburger.Models;

namespace pizburger.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext context;

        public OrderController(AppDbContext context)
        {
            this.context = context;
        }






        [HttpGet("orders", Name = "order-route")]
        public IActionResult Index()
        {
            var orderlist = this.context.orders.ToList();

            var model = new OrderIndexViewModel
            {
                orders = orderlist,


            };
            return View(model);


        }


        [HttpGet("order-ekle", Name = "create-route")]
        public IActionResult Create()
        {


            return View();
        }



        [HttpPost("order-ekle", Name = "create-route")]
        public IActionResult Create(OrderCreateViewModel viewModel)
        {

            var order = new order()
            {
                Name = viewModel.Name,
                Description = viewModel.Description,


            };

            context.orders.Add(order);
            int result = context.SaveChanges();

            return RedirectToAction("Index");
        }









    }
}
