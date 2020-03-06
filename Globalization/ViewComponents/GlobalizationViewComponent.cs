using Globalization.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globalization.ViewComponents
{
    [ViewComponent]
    public class GlobalizationViewComponent : ViewComponent
    {


       
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public GlobalizationViewComponent(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        public IViewComponentResult Invoke()
        {
            
            var selectedCulture = HttpContext.Request.Query["culture"];
            var selectedLanguage = 0;
            if (!string.IsNullOrWhiteSpace(selectedCulture) && selectedCulture == "en-US")
            {
                selectedLanguage = 1;
            }
            
            var languageModel = new LanguageModel() { SelectedLanguage = selectedLanguage, LangName = (Language)selectedLanguage };
            return View(languageModel);

        }

    }
}

