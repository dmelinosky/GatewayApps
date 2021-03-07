using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagesSite.Services
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

        public virtual string ImagesLink()
        {
            if (environment.IsDevelopment() && !useProxy)
            {
                return "/";
            }
            else
            {
                return "/images";
            }
        }

        public virtual string ThingsLink()
        {
            if (environment.IsDevelopment() && !useProxy)
            {
                return "/things";
            }
            else
            {
                return "/images/things";
            }
        }
    }
}
