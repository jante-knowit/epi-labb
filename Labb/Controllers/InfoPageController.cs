using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Labb.Models.Pages;
using Labb.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Labb.Controllers
{
    public class InfoPageController : PageController<InfoPage>
    {
        private readonly IContentRepository _contentRepository;

        public InfoPageController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }
        public ActionResult Index(InfoPage currentPage)
        {
            DefaultPageViewModel<InfoPage> viewModel = new DefaultPageViewModel<InfoPage>(currentPage);
            List<PageData> menuItems = GetMenuItems();
            viewModel.MenuItems = menuItems;
            return View(viewModel);
        }

        private List<PageData> GetMenuItems()
        {
            List<PageData> menuItems = new List<PageData>();

            menuItems = _contentRepository.GetChildren<PageData>(ContentReference.StartPage).ToList();

            return menuItems;
        }
    }
}