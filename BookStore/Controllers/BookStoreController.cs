using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookStoreController : ControllerBase
    {
        private static List<Book> _memoryStore = new List<Book>();

        private readonly ILogger<WeatherForecastController> _logger;

        public BookStoreController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        [Route("RetrieveBook")]
        public async Task<IActionResult> RetrieveBook(string bookNumber)
        {
            if ( String.IsNullOrEmpty( bookNumber ) == null)
            {
                return BadRequest();
            }

            try
            {
                if( _memoryStore.Exists( b => b.BookNumber == bookNumber  ))
                {
                    Book book = _memoryStore.First( b => b.BookNumber == bookNumber );
                    return Ok(book);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("CreateBook")]
        public async Task<IActionResult> CreateBook([FromBody]Book model)
        {
            try
            {
                if( _memoryStore.Exists( b => b.BookNumber == model.BookNumber  ))
                {
                    return BadRequest();
                }
                else
                {
                    _memoryStore.Add( model );
                    return Ok(model);
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut]
        [Route("UpdateBook")]
        public async Task<IActionResult> UpdateBook([FromBody]Book model)
        {
            try
            {
                if( _memoryStore.Exists( b => b.BookNumber == model.BookNumber  ) == false )
                {
                    return NotFound();
                }

                Book book = _memoryStore.First( b => b.BookNumber == model.BookNumber );
                book = model;
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return BadRequest();
        }


        [HttpDelete]
        [Route("DeleteBook")]
        public async Task<IActionResult> DeleteBook(string booknumber)
        {

            if (String.IsNullOrEmpty(booknumber))
            {
                return BadRequest();
            }

            try
            {
                if( _memoryStore.Exists( b => b.BookNumber == booknumber  ) == false )
                {
                    return NotFound();
                }

                Book book = _memoryStore.First( b => b.BookNumber == booknumber );
                _memoryStore.Remove( book );
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }

}
