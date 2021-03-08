
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CommonUI
{
    public class CommonMenuViewComponent : ViewComponent
    {
        readonly IMenuItemGenerationService menuService;

        public CommonMenuViewComponent(IMenuItemGenerationService menuItemGeneration)
        {
            this.menuService = menuItemGeneration;
        }

        public IViewComponentResult Invoke()
        {
            CommonMenuViewModel model = new CommonMenuViewModel
            {
                MenuItems = this.menuService.GenerateMenuItems(),
                IsLoggedIn = this.UserClaimsPrincipal != null && this.UserClaimsPrincipal.Identity.IsAuthenticated,
            };

            return View(model);
        }
    }

    public interface IMenuItemGenerationService
    {
        IEnumerable<MenuItem> GenerateMenuItems();
    }

    public class InMemoryMenuItemGenerationService : IMenuItemGenerationService
    {
        public virtual IEnumerable<MenuItem> GenerateMenuItems()
        {
            var items = new List<MenuItem>
            {
                new MenuItem("Home", "/"),
                new MenuItem("Privacy", "/privacy"),
                new MenuItem("Images", "/images")
                {
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem("Things", "/images/things")
                    }
                },
                new MenuItem("Videos", "/videos")
                {
                    SubItems = new List<MenuItem>
                    {
                        new MenuItem("Stuff", "/videos/stuff")
                    }
                }
            };

            return items;
        }
    }

    public class CommonMenuViewModel
    {
        public IEnumerable<MenuItem> MenuItems { get; set; }

        public bool IsLoggedIn { get; set; }
    }


    public class MenuItem
    {
        public MenuItem()
        {
        }

        public MenuItem(string text, string link)
        {
            this.Text = text;
            this.Link = link;
        }

        public string Text { get; set; }

        public string Link { get; set; }

        public List<MenuItem> SubItems { get; set; } = new List<MenuItem>();


    }
}
