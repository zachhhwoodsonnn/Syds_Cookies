using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieSite.Pages;

[BindProperties]
public class HomeScreenModel : PageModel
{
    public void OnGet()
    {
    }
    public RedirectResult OnPostFourPack()
    {
        return Redirect("ProductInfoFourPack");
    }
    public RedirectResult OnPostSixPack()
    {
        return Redirect("ProductInfoSixPack");
    }
    public RedirectResult OnPostEightPack()
    {
        return Redirect("ProductInfoEightPack");
    }
    public RedirectResult OnPostTwelvePack()
    {
        return Redirect("ProductInfoTwelvePack");
    }
}
