using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peppi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryRepository categoryRepository = new CategoryRepository();
        ProductRepository productRepository = new ProductRepository();
        DataContext db = new DataContext();
        public PartialViewResult CategoryList()
        {
            var category = categoryRepository.List();
            ViewBag.list = category;
            return PartialView(category);
        }
    }
}