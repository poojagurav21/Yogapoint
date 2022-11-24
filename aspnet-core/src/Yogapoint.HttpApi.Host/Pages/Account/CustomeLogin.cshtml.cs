using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Threading.Tasks;
using Volo.Abp.Account.Settings;
using Volo.Abp.Account.Web;
using Volo.Abp.Account.Web.Pages.Account;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.Identity.AspNetCore;
using Volo.Abp.Settings;

namespace Yogapoint.Pages.Account
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(LoginModel))]
    public class CustomeLoginModel : LoginModel
    {
        public CustomeLoginModel(IAuthenticationSchemeProvider schemeProvider, 
            IOptions<AbpAccountOptions> accountOptions, 
            IOptions<IdentityOptions> identityOptions) : 
            base(schemeProvider, accountOptions, identityOptions)
        {
        }

        //public void OnGet()
        //{
        //}
        //public override async Task<IActionResult> OnPostAsync(string action)
        //{
        //    await CheckLocalLoginAsync();

        //    ValidateModel();

        //    ExternalProviders = await GetExternalProviders();

        //    EnableLocalLogin = await SettingProvider.IsTrueAsync(AccountSettingNames.EnableLocalLogin);

        //    await ReplaceEmailToUsernameOfInputIfNeeds();

        //    await IdentityOptions.SetAsync();

        //    var result = await SignInManager.PasswordSignInAsync(
        //        LoginInput.UserNameOrEmailAddress,
        //        LoginInput.Password,
        //        LoginInput.RememberMe,
        //        true
        //    );

        //    await IdentitySecurityLogManager.SaveAsync(new IdentitySecurityLogContext()
        //    {
        //        Identity = IdentitySecurityLogIdentityConsts.Identity,
        //        Action = result.ToIdentitySecurityLogAction(),
        //        UserName = LoginInput.UserNameOrEmailAddress
        //    });

        //    if (result.RequiresTwoFactor)
        //    {
        //        return await TwoFactorLoginResultAsync();
        //    }

        //    if (result.IsLockedOut)
        //    {
        //        Alerts.Warning(L["UserLockedOutMessage"]);
        //        return Page();
        //    }

        //    if (result.IsNotAllowed)
        //    {
        //        Alerts.Warning(L["LoginIsNotAllowed"]);
        //        return Page();
        //    }

        //    if (!result.Succeeded)
        //    {
        //        Alerts.Danger(L["InvalidUserNameOrPassword"]);
        //        return Page();
        //    }

        //    //TODO: Find a way of getting user's id from the logged in user and do not query it again like that!
        //    var user = await UserManager.FindByNameAsync(LoginInput.UserNameOrEmailAddress) ??
        //               await UserManager.FindByEmailAsync(LoginInput.UserNameOrEmailAddress);

        //    Debug.Assert(user != null, nameof(user) + " != null");

        //    return RedirectSafely(ReturnUrl, ReturnUrlHash);
        //}
    }
}
