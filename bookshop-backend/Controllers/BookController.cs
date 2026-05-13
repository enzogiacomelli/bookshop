using bookshop_backend.DTOs;
using bookshop_backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookshop_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookService _bookService;  //o controller chama o service, o service chama o repository, o repository chama o banco de dados

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Post(CreateBookDto dto)
        {
            try
            {
                _bookService.CreateBook(dto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
