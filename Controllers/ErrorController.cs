// using ErrataManager.Models;
// using ErrataManager.Data;
// using ErrataManager.Services;
// using Microsoft.AspNetCore.Mvc;

// namespace ErrataManager.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class ErrorController : ControllerBase
// {
//     ErrorService _service;

//     public ErrorController(ErrorService service){
//         _service = service;
//     }

//     // Get all errors
//     [HttpGet("{id}")]
//     public async Task<IEnumerable<Error>?> GetAllErrorsAsync(int id){
//         return await Task.FromResult(_service.GetAllErrorsSync(id));
//     }

//     // Get Error by Id
//     [HttpGet("{errorId}")]
//     public async Task<Error?> GetErrorById(int errorId){
//         return await Task.FromResult(_service.GetErrorById(errorId));
//     }

    

// }