using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Usmc.Steward.Banker.Pages;

public class IndexModel : BankerPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
