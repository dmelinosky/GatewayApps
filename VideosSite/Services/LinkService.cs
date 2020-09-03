using Microsoft.AspNetCore.Hosting;
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

        public LinkService(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public virtual string VideoLink()
        {
            if (environment.IsDevelopment())
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
            if (environment.IsDevelopment())
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
