/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api")]
    public class ConfigurationController : Controller
    {
        public ConfigurationController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private IConfiguration Configuration
        {
            get; set;
        }

        [HttpGet("appname")]
        public string ApplicationName()
        {
            return "School";
        }
    }
}
