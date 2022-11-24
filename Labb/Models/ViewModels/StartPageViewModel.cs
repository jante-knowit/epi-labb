using Labb.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb.Models.ViewModels
{
    public class StartPageViewModel : DefaultPageViewModel<StartPage>
    {
        public string Greeting { get; set; }
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {

        }
    }
}