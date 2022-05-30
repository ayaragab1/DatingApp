using DatingApp.Date;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    public class ValueController : Controller
    {
        private readonly DataContext _context;

        public ValueController( DataContext context)
        {
            _context = context;
        }
        [HttpGet("Api/Value/GetValues")]
        public async Task<IActionResult> GetValues()
        {
            var values =await _context.Values.ToListAsync();
            return Ok(values); 
        }

        [HttpGet("Api/Value/{id}/GetValue")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(i=>i.Id==id);
            return Ok(value);
        }
    }
}
