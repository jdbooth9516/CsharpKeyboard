using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace customKeyboard.Models
{
  public class ShippingAddress
  {
    public int ShippingAddressId { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }


    [ForeignKey("User")]
    public int userId { get; set; }
    public User user { get; set; }
  }
}