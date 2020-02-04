using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
  public class OrdersController : Controller
  {
    private readonly EcommerceContext _db;

    public OrdersController(EcommerceContext db)
    {
      _db = db;
    }

    // [HttpPost]
    // public ActionResult Create(Product newProduct)
    // {
    //   //try loading order from order table, if order found for customer, use fetched order from db. 
    //   //else create new order and add to db.
    //   Order newOrder = new Order();
    //   newOrder.AddProduct(newProduct);
    //   _db.Orders.Add(newOrder);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index","Products");
    // }
  }
} 