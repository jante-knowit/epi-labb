using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }
        List<PageData> MenuItems { get; set; }
    }
}
