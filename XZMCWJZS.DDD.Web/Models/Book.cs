using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XZMCWJZS.DDD.Web.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "必须输入图书名称")]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "最多允许输入100个字符")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "必须输入作者名称")]
        public string Author { get; set; }
        [Required(ErrorMessage = "必须输入出版社名称")]
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string Remark { get; set; }
    }
}