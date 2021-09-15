using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace customKeyboard.Models
{
  public class ShoppingCarts
  {
    public int ShoppingCartsId { get; set; }


    [ForeignKey("User")]
    public string UserId { get; set; }
    public User User { get; set; }


    [ForeignKey("Builds")]
    public int BuildsId { get; set; }
    public Builds Builds { get; set; }
  }
}