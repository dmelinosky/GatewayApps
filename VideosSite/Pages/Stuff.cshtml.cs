using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using VideoSite.Models;

namespace VideosSite.Pages
{
    public class StuffModel : PageModel
    {
        public string AppName { get; private set; }

        public void OnGet([FromServices] IOptions<NamesOptions> options)
        {
            this.AppName = options.Value.AppName;
        }
    }
}
