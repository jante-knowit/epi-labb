using EPiServer.Web.Mvc;
using Labb.Models.Pages;
using Labb.Models.ViewModels;
using System;
using System.Web.Mvc;

namespace Labb.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        
        public ActionResult Index(StartPage currentPage)
        {
            StartPageViewModel viewModel = new StartPageViewModel(currentPage);
            SetGreeting(viewModel);
            return View(viewModel);
        }

        private void SetGreeting(StartPageViewModel viewModel)
        {            
            DateTime currentTime = DateTime.Now;
            if(currentTime.Hour < 8)
            {
                viewModel.Greeting = "God morgon!";    
            }
            else if (currentTime.Hour < 13)
            {
                viewModel.Greeting = "God förmiddag!";
            }
            else if(currentTime.Hour < 19)
            {
                viewModel.Greeting = "God eftermiddag!";
            }
            else
            {
                viewModel.Greeting = "God kväll!";
            }
        }
    }
}