using Lesson6.Models;
using Lesson6.Models.ViewModels;
using Lesson6.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Lesson6.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> products = new();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {

                #region Manual

                //Product product = new()
                //{
                //    Name = model.Name,
                //    Description = model.Description,
                //    Price = model.Price,
                //    Quantity = model.Quantity,
                //    Rating = 0,
                //    Id = 1
                //};
                //products.Add(product);

                #endregion

                #region ExplicitOperatorOverload

                //var product = (Product)model;

                //products.Add(product);

                #endregion

                #region ImplicitOperatorOverload

                //products.Add(model);

                #endregion

                #region Reflection

                Product product = TypeConvertion.Convert<Product, AddProductViewModel>(model);
                products.Add(product);

                #endregion


                return View();

            }
            return View("Error.cshtml");
        }

    }
}
