using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pakohuone.Data;

namespace Pakohuone.Areas.Admin.Controllers
{
    public class LevelsController : AdminControllerBase
    {
        private readonly PakohuoneContext _pakohuone;

        public LevelsController(PakohuoneContext pakohuone)
        {
            _pakohuone = pakohuone;
        }

        public async Task<IActionResult> Index()
        {
            var levels = await _pakohuone.Levels.ToListAsync();

            return View(levels);
        }
    }
}
