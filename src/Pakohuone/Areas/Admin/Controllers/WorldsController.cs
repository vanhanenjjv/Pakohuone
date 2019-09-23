using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pakohuone.Common;
using Pakohuone.Data;
using Pakohuone.Entities;
using Pakohuone.Extensions;
using Pakohuone.Models.Bootstrap;

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

        #region Edit

        public async Task<IActionResult> Edit(int id)
        {
            var world = await _pakohuone.Worlds.FirstOrDefaultAsync(w => w.Id == id);

            if (world == null)
                return NotFound();

            return View(world);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditWorld(int id)
        {
            var world = await _pakohuone.Worlds.FirstOrDefaultAsync(w => w.Id == id);

            if (await TryUpdateModelAsync(
                world,
                "",
                w => w.Name,
                w => w.Time))
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

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            throw new NotImplementedException();
        }
    }
}
