using ErrataManager.Models;
using ErrataManager.Services;
using ErrataManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace ErrataManager.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{  
    BookService _service;

    public BookController(BookService service){
        _service = service;
    }

    
}