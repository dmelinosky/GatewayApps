using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImagesSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ImagesSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly IOptions<NamesOptions> options;

        public IndexModel(ILogger<IndexModel> logger, IOptions<NamesOptions> options)
        {
            this.logger = logger;
            this.options = options;
        }

        public string AppName { get; private set; }

        public void OnGet()
        {
            this.AppName = this.options.Value.AppName;
        }
    }
}
