using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUI
{
    public class CommonFooterViewComponent : ViewComponent
    {
        readonly IMenuItemGenerationService menuService;

        public CommonFooterViewComponent(IMenuItemGenerationService menuItemGeneration)
        {
            this.menuService = menuItemGeneration;
        }

        public IViewComponentResult Invoke()
        {
            var privacyItem = this.menuService.GenerateMenuItems().SingleOrDefault(x => x.Text == "Privacy");

            CommonFooterViewModel model = new CommonFooterViewModel
            {
                Privacy = privacyItem,
            };

            return View(model);
        }
    }

    public class CommonFooterViewModel
    {
        public MenuItem Privacy { get; set; }

        public string YearString => DateTime.Now.Year.ToString();
    }
}
