using FizzBuzz.Domain.Abstract;
using FizzBuzz.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzz.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInteraction _interaction;
        private readonly IItemRepository _repo;
        private readonly IAppItem _appItem;

        public HomeController(IInteraction interaction,
            IItemRepository repo,
            IAppItem appItem)
        {
            this._interaction = interaction;
            this._repo = repo;
            this._appItem = appItem;

        }

        public ActionResult Index()
        {
            var viewModel = new AppViewModel {
                AppItem = _repo.GetAppItem(_appItem)
            };

            return View(viewModel);
        }

        public JsonResult FizzBuzz(string input)
        {
            var output = _interaction.Start(Convert.ToInt32(input));
            return Json(output, JsonRequestBehavior.AllowGet);

        }
    }
}