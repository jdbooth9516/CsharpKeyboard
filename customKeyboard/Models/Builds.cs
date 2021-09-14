
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace customKeyboard.Models
{
  public class Builds
  {
    public int BuildsId { get; set; }

    public string Name { get; set; }


    [ForeignKey("Products")]
    public int ProductId { get; set; }

    public Products Products { get; set; }

    public double BuildPrice { get; set; }

  }
}