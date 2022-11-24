using EPiServer;
using EPiServer.Core;
using System.Collections.Generic;

namespace Labb.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
        public T CurrentPage { get; set; }

        public List<PageData> MenuItems { get; set; }
    }
}