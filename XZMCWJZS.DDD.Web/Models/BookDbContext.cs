using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XZMCWJZS.DDD.Web.Models
{
    public class BookDbContext:DbContext
    {
        public BookDbContext() : base("name=BookDbContext") { }
        public DbSet<Book> Books { get; set; }
    }
}