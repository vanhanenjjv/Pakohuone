using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pakohuone.Common;
using Pakohuone.Data;
using Pakohuone.Extensions;
using Pakohuone.Models.Bootstrap;

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

        #region Edit

        public async Task<IActionResult> Edit(int id)
        {
            var room = await _pakohuone.Rooms
                .Include(r => r.World)
                .Include(r => r.Level)
                .FirstOrDefaultAsync(w => w.Id == id);

            if (room == null)
                return NotFound();

            ViewData["Worlds"] = new SelectList(this._pakohuone.Worlds, "Id", "Name", room.World?.Id);
            ViewData["Levels"] = new SelectList(this._pakohuone.Levels, "Id", "Name", room.Level?.Id);

            return View(room);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditRoom(int id)
        {
            var room = await _pakohuone.Rooms
                .Include(r => r.World)
                .Include(r => r.Level)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (await TryUpdateModelAsync(
                room,
                "",
                r => r.LevelId))
            {
                try
                {
                    await _pakohuone.SaveChangesAsync();
                    TempData.PutAlert(new Alert(GenericMessage.Save, AlertType.Success));
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", GenericMessage.Error);
                    TempData.PutAlert(new Alert(GenericMessage.Error, AlertType.Danger));
                }
            }

            return RedirectToAction(nameof(Edit));
        }

        #endregion
    }
}
