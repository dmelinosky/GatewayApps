using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MainSite.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> logger;
        private readonly IOptions<NamesOptions> options;

        public PrivacyModel(ILogger<PrivacyModel> logger, IOptions<NamesOptions> options)
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
