
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace customKeyboard.Models
{
  public class Builds
  {
    public int BuildsId { get; set; }
    [Required]
    public string Name { get; set; }

    [ForeignKey("Products")]
    [Required]
    public int ProductId { get; set; }
    public Products Product { get; set; }
  }
}