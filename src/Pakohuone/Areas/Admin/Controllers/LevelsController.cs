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

        #region Edit

        public async Task<IActionResult> Edit(int id)
        {
            var level = await _pakohuone.Levels.FirstOrDefaultAsync(w => w.Id == id);

            if (level == null)
                return NotFound();

            return View(level);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditLevel(int id)
        {
            var level = await _pakohuone.Levels.FirstOrDefaultAsync(l => l.Id == id);

            if (await TryUpdateModelAsync(
                level,
                "",
                l => l.Name))
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
