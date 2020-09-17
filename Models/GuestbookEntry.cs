using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using endrde_guestbook.Models;

namespace endrde_guestbook.Models
{
    public class GuestbookEntry
    {
        public DateTime EntryDateTime { get; set; }
        public string GuestName { get; set; }
        public string GuestMessage { get; set; }

        public GuestbookEntry(string name, string message)
        {
            this.GuestName = name;
            this.GuestMessage = message;
            this.EntryDateTime = DateTime.Now;
        }
    }
}