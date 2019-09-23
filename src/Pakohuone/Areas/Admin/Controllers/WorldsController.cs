using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pakohuone.Common;
using Pakohuone.Data;
using Pakohuone.Entities;
using Pakohuone.Extensions;
using Pakohuone.Models.Bootstrap;
using Pakohuone.Services;

namespace Pakohuone.Areas.Admin.Controllers
{
    public class WorldsController : AdminControllerBase
    {
        private readonly PakohuoneContext _pakohuone;
        private readonly WorldService _worlds;

        public WorldsController(PakohuoneContext pakohuone, WorldService worlds)
        {
            _pakohuone = pakohuone;
            _worlds = worlds;
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

        [DisableRequestSizeLimit]
        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            if (file.ContentType != MediaType.ZipArchive)
                return BadRequest();

            if (!(_worlds.TryAddWorld(file.OpenReadStream(), out World world)))
            {
                TempData.PutAlert(new Alert(GenericMessage.Error, AlertType.Danger));
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Edit), new { id = world.Id });
        }
    }
}
