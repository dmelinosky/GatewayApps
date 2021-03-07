using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideosSite.Services
{
    public class LinkService
    {
        private readonly IWebHostEnvironment environment;
        private readonly bool useProxy;

        public LinkService(IWebHostEnvironment environment, IConfiguration configuration)
        {
            this.environment = environment;
            this.useProxy = configuration.GetValue<bool>("UseProxy");
        }

        public virtual string VideoLink()
        {
            if (environment.IsDevelopment() && !this.useProxy)
            {
                return "/";
            }
            else
            {
                return "/video";
            }
        }

        public virtual string StuffLink()
        {
            if (environment.IsDevelopment() && !this.useProxy)
            {
                return "/Stuff";
            }
            else
            {
                return "/video/stuff";
            }
        }
    }
}
