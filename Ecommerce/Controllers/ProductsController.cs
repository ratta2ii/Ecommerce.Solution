  
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ecommerce.Controllers
{
  public class ProductsController : Controller
  {
    private readonly EcommerceContext _db;

    public ProductsController(EcommerceContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Product> model = _db.Products.ToList();
      return View(model);
    }

    [HttpGet]
    public ActionResult Details(int Id)  // Replace argument with (int id)
    {
      var products = _db.Products.FirstOrDefault(product => product.ProductId == Id);  // Replace this 1 value with the argument (id)
      return View(products);
    }


    [HttpPost]
    public ActionResult Details(Product newProduct) //technically addtocart
    {
      System.Console.WriteLine("start of addtocart");
      int? OrderId = HttpContext.Session.GetInt32("OrderId");
      //try loading order from order table, if order found for customer, use fetched order from db. 
      //else create new order and add to db.
      Order thisOrder;
      if (OrderId == null)
      {
         thisOrder = new Order();
      }
      else
      {
         thisOrder = _db.Orders.FirstOrDefault(orders => orders.OrderId == OrderId);
      }
        
      OrderProduct newOrderProduct = new OrderProduct(newProduct.ProductId, thisOrder.OrderId);
      thisOrder.AddProduct(newOrderProduct);
      _db.Orders.Add(thisOrder);

      // _db.OrderProduct.Add(newOrderProduct);
      // _db.SaveChanges();
      // HttpContext.Session.SetInt32("orderId", thisOrder.OrderId);
      // OrderProduct newOrderProduct = new OrderProduct(newProduct.ProductId, thisOrder.OrderId);
        _db.OrderProduct.Add(newOrderProduct);
      _db.SaveChanges();
      HttpContext.Session.SetInt32("OrderId", thisOrder.OrderId);
      System.Console.WriteLine("Saved Order Successful!");
      return RedirectToAction("Index","Products");
    }
  }
}