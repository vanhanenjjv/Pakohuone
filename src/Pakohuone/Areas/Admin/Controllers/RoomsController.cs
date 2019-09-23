using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pakohuone.Data;

namespace Pakohuone.Areas.Admin.Controllers
{
    public class RoomsController : AdminControllerBase
    {
        private readonly PakohuoneContext _pakohuone;

        public RoomsController(PakohuoneContext pakohuone)
        {
            _pakohuone = pakohuone;
        }

        public async Task<IActionResult> Index()
        {
            var rooms = await _pakohuone.Rooms
                .Include(r => r.World)
                .Include(r => r.Level)
                .ToListAsync();

            return View(rooms);
        }
    }
}
