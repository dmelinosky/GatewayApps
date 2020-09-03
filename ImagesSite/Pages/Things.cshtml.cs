using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImagesSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ImagesSite.Pages
{
    public class ThingsModel : PageModel
    {
        private readonly IOptions<NamesOptions> options;

        public ThingsModel(IOptions<NamesOptions> options)
        {
            this.options = options;
        }

        public string AppName { get; private set; }

        public void OnGet()
        {
            this.AppName = this.options.Value.AppName;
        }
    }
}
