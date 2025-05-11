using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using simple_bookstore_api.Communication;
using simple_bookstore_api.Communication.Response;

namespace simple_bookstore_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController: ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var response = new Book()
        {
            Id = 1,
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Genre = "Fiction",
            Price = 10,
            Stock = 100
        };
        return Ok(response);
    }
    
        [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody]RequestRegisteredBookJson request)
    {
        var response = new ResponseRegisteredBookJson
        {
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price
        };
        
        return Created(string.Empty, response);
    }
    
    [HttpGet("all")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Fiction",
                Price = 10,
                Stock = 100
            },  
            new Book()
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                Price = 15,
                Stock = 50
            },
           
        };  
        
        return Ok(response);
    }
    
    [HttpPut()]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Edit([FromBody] RequestEditBookJson request)
    {
        return NoContent();
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

}