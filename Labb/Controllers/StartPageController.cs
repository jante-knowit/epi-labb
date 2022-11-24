using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using Labb.Models.Pages;
using Labb.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Labb.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        private readonly IContentRepository _contentRepository;

        public StartPageController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }
        public ActionResult Index(StartPage currentPage)
        {
            StartPageViewModel viewModel = new StartPageViewModel(currentPage);
            string greeting = GetGreeting();
            viewModel.Greeting = greeting;
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

        private string GetGreeting()
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour < 10)
                return "God morgon!";
            if (currentTime.Hour < 12)
                return "God förmiddag";
            if (currentTime.Hour < 19)
                return "God eftermiddag";
            else
                return "God kväll!";
        }
    }
}