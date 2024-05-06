using Microsoft.AspNetCore.Mvc;
using PersonelTakipManager;
using PersonelTakipModel;

namespace PersonelTakip.Controllers
{
    [Route("departman")]
    public class DepartmanController : Controller
    {
        [HttpGet,Route("")]
        public async Task<ViewResult> Index()
        {
            List<Departman> departmanlar = await DepartmanManager.TumunuGetir();
            return View(departmanlar);
           
        }

        [HttpGet,Route("yeni")]
        public ViewResult Yeni()
        {
            return View();
        }

        [HttpPost,Route("ekle")]
        public async Task<ActionResult> Ekle(Departman departman)
        {
            await DepartmanManager.Ekle(departman);
            return RedirectToAction("Index");
        }

        [HttpGet,Route("sil")]
        public async Task<ActionResult> Sil(Guid id)
        {
            await DepartmanManager.Sil(id);
            return RedirectToAction("Index");
        }

        [HttpPost,Route("guncelle")]
        public async Task<ActionResult> Guncelle(Departman departman)
        {
            await DepartmanManager.Guncelle(departman);
            return RedirectToAction("Index");
        }

        [HttpGet,Route("duzenle/{id}")]

        public async Task<ActionResult> Duzenle(Guid id)
        {
            Departman?  departman = await DepartmanManager.Getir(id);
            return View(departman);
        }
    }
}
