using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSystem.Database.Models;

namespace OrderSystem.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Cart()
        {
            //var user = Session["User"] as User;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
                // Return the view
                return View();
        }
        
        [HttpPost]
        public IActionResult AddToCart(int itemId = 0)
        {
            //var user = Session["User"] as User;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            // Return the view
            return View();
        }
        //private int isExisting(int id)
        //{
        //    List<Part> cart = (List<Part>)Session["cart"];
        //    for (int i = 0; i < cart.Count; i++)
        //        if (cart[i].PartId == id)
        //            return i;
        //    return -1;
        //}
        //public ActionResult Delete(int id)
        //{
        //    int index = isExisting(id);
        //    List<Part> cart = (List<Part>)Session["cart"];
        //    cart.RemoveAt(index);
        //    HttpContext.Session.("cart", cart);
        //    return View("Cart");
        //}
        //public ActionResult OrderNow(int id)
        //{
        //    if (Session["cart"] == null)
        //    {
        //        List<Part> cart = new List<Part>();
        //        // cart.Add(new Item())
        //        Session["cart"] = cart;
        //    }
        //    else
        //    {

        //        List<Part> cart = (List<Part>)Session["cart"];
        //        int index = isExisting(id);
        //        if (index == -1)
        //        {
        //            // cart.Add(new Item())
        //        }
        //        else
        //            cart[index].Quantity++;

        //        Session["cart"] = cart;
        //    }
        //    return View("Cart");
        //}

        //public ActionResult Update(System.Web.Mvc.FormCollection fc)
        //{
        //    if (fc.Count > 0)
        //    {
        //        string[] quantities = fc.GetValues("quantity");
        //        List<Part> cart = (List<Part>)Session["cart"];
        //        for (int i = 0; i < cart.Count; i++)
        //            cart[i].Quantity = Convert.ToInt32(quantities[i]);
        //        Session["cart"] = cart;
        //    }
        //    return View("Cart");
        //}

        //public ActionResult Checkout()
        //{
        //    return View("Ckeckout");
        //}

        //public ActionResult saveOrder()
        //{
        //    DateTime date = DateTime.Now;

        //    var items = (List<Part>)Session["cart"];

        //    //foreach (var i in items)
        //    //{
        //    //    var item = addEditDeleteService.GetItemByName(i.Name);
        //    //    addEditDeleteService.InsertSale(new Sales()
        //    //    {
        //    //        ItemId = item.Id,
        //    //        Date = date,
        //    //        Quantity = i.Quantity,
        //    //        ClientId = client.Id
        //    //    });
        //    //    item.Quantity -= i.Quantity;

        //    //    addEditDeleteService.UpdateItem(item);
        //    //}
        //    //Session.Remove("cart");

        //    return RedirectToAction("Index", "Home");
        //}

        //[System.Web.Mvc.ChildActionOnly]
        //public ActionResult CartSummary()
        //{
        //    List<Part> cart;
        //    if (Session["cart"] == null)
        //    {
        //        cart = new List<Part>();
        //        Session["cart"] = cart;
        //    }
        //    else
        //        cart = (List<Part>)Session["cart"];

        //    ViewData["CartCount"] = cart.Count();
        //    return PartialView("CartSummary");
        //}
    }
}
