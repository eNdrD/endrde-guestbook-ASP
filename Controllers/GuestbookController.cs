using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using endrde_guestbook.Models;

namespace endrde_guestbook.Controllers
{
    public class GuestbookController : Controller
    {
        private readonly ILogger<GuestbookController> _logger;

        public GuestbookController(ILogger<GuestbookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        [Route("Guestbook/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuestbookEntry(string guestname, string guestmessage)
        {
            var entry = new GuestbookEntry(guestname, guestmessage);
            Guestbook.ListOfGuestbookEntries.Add(entry);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
