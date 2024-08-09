using Demo.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("/api/DemoBot")]
    public class DemoController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public DemoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _dataContext.Demos.ToListAsync());
        }
    }
}
