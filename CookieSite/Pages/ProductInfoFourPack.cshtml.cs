using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieSite.Pages;

[BindProperties]
public class ProductInfo4PackModel : PageModel
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
