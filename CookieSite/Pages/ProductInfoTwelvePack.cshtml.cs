using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieSite.Pages;

public class ProductInfoTwelvePackModel : PageModel
{
    public void OnGet()
    {
    }
    public RedirectResult OnPostBackToMenu()
    {
        return Redirect("HomeScreen");
    }
    public RedirectResult OnPostCheckout()
    {
        HttpContext.Session.SetString("goBack", Request.GetDisplayUrl());
        return Redirect("Checkout");
    }
}
