using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HomeStay.Pages
{
    public class RoomDetails : PageModel
    {
        private readonly ILogger<RoomDetails> _logger;

        public RoomDetails(ILogger<RoomDetails> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
