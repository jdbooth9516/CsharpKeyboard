using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace customKeyboard.Models
{
    public class Products
    {
        public int  ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDisc { get; set; }
        public string LongDisc { get; set; }

        public double Price { get; set; }
        
        public string Photo { get; set; }
        
        public string Catagory { get; set; }

  }
}