using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using prac1.Models;

namespace prac1.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> index()
    {
        var model=new StockQuote {System="Hello", Price=6000};
        return View(model);
    }
}
