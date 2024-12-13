using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieSite.Pages;

public class CheckoutModel : PageModel
{
    public void OnGet()
    {
    }

    public RedirectResult OnPostGoBack()
    {
        var goBack = HttpContext.Session.GetString("goBack");
        return Redirect(goBack);
    }
}
