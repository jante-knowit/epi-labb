using Labb.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb.Models.ViewModels
{
    public class StartPageViewModel
    {
        public StartPage CurrentPage { get; set; }
        public string Greeting { get; set; }
        public StartPageViewModel(StartPage currentPage)
        {
            this.CurrentPage = currentPage;
        }
    }
}