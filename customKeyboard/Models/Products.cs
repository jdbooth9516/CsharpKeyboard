using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace customKeyboard.Models
{
  public class Products
  {

    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortDisc { get; set; }
    public string LongDisc { get; set; }

    public double Price { get; set; }

    public string Photo { get; set; }

    public string Catagory { get; set; }

    public List<Builds> Builds { get; set; }
  }
}