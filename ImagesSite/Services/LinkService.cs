using Microsoft.AspNetCore.Hosting;
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

        public LinkService(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public virtual string ImagesLink()
        {
            if (environment.IsDevelopment())
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
            if (environment.IsDevelopment())
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
