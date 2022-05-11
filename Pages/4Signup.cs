using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HomeStay.Pages
{
    public class SignupModel : PageModel
    {
        private readonly ILogger<SignupModel> _logger;

        public SignupModel(ILogger<SignupModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
