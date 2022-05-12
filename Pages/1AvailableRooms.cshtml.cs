﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HomeStay.Pages
{
    public class AvailableRooms : PageModel
    {
        private readonly ILogger<AvailableRooms> _logger;

        public AvailableRooms(ILogger<AvailableRooms> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
