using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using customKeyboard.Data;
using customKeyboard.Models;


namespace customKeyboard.Controllers
{

  //     this is the root route for every api in this class

  [Route("/api/products")]
  [ApiController]

  // must inheirate the controller base 
  public class ProductController : ControllerBase
  {
    private readonly ApplicationDbContext _context;
    public ProductController(ApplicationDbContext context)
    {
      _context = context;
    }
    //@Route Post api/products
    //@disc add a product to the database
    //@auth public 
    [HttpPost]
    public IActionResult PostProduct([FromBody] Products value)
    {
      //adds the value to the db
      _context.Products.Add(value);
      // save the db
      _context.SaveChanges();
      // return the result
      return StatusCode(201, value);

    }

    //@path  Get api/products
    //@disc Get all products from the DB
    //@auth public 
    [HttpGet]
    public IActionResult GetAllProducts()
    {
      var products = _context.Products;
      return Ok(products);
    }

    //@path  Get api/products/cateforyName
    //@disc Get products by category
    //@auth public 

    [HttpGet("{categoryName}")]
    public IActionResult GetProductsByCategory(string categoryName)
    {
      // get all the Products from the database
      var products = _context.Products;
      var filteredProducts = products.Where(product => product.Catagory == categoryName);
      return Ok(filteredProducts);

    }
  }
}