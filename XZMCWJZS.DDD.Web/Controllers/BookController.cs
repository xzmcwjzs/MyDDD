using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XZMCWJZS.DDD.Web.Models;

namespace XZMCWJZS.DDD.Web.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        readonly BookDbContext db = new BookDbContext();
        public ActionResult Init()
        {
            if (db.Database.CreateIfNotExists())
            {
                return Content("数据库已创建成功！");
            }
            else
            {
                return Content("数据库已经存在，无需创建！");
            }
        }
        public ActionResult Index()
        {
            var books = from b in db.Books
                        where b.Author == "王杰"
                        select b;
            return View(books.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }
    }
}