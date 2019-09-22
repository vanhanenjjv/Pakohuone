using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pakohuone.Data;

namespace Pakohuone.Areas.Admin.Controllers
{
    public class WorldsController : AdminControllerBase
    {
        private readonly PakohuoneContext _pakohuone;

        public WorldsController(PakohuoneContext pakohuone)
        {
            _pakohuone = pakohuone;
        }

        public async Task<IActionResult> Index()
        {
            var worlds = await _pakohuone.Worlds.ToListAsync();

            return View(worlds);
        }
    }
}
