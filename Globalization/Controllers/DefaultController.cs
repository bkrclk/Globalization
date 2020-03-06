using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globalization.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace Globalization.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ILogger<DefaultController> _logger;
        private readonly IStringLocalizer<DefaultController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public DefaultController(ILogger<DefaultController> logger, IStringLocalizer<DefaultController> localizer, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _logger = logger;
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;

        }

        public IActionResult Index()
        {

            ViewData["Create"] = _sharedLocalizer.GetString("Create");
            return View();
        }
    }
}