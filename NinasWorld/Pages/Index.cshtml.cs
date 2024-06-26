﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NinasWorld.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Redirect to the login page
        return RedirectToPage("./Intro");
    }

    public IActionResult OnGet()
    {
        // Redirect to the login page
        return RedirectToPage("./Intro");
        //return RedirectToPage("./Inicio");

    }
}

