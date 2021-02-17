using System;

namespace IdentityServerHost.Quickstart.UI
{
    public static class AccountOptions
    {
        public static bool AllowLocalLogin = true;
        public static bool AllowRememberLogin = true;
        public static TimeSpan RememberMeLoginDuration = TimeSpan.FromDays(30);

        public static bool ShowLogoutPrompt = true;
        public static bool AutomaticRedirectAfterSignOut = false;

        public static string InvalidCredentialsErrorMessage = "Invalid username or password";
        public static string DeletedUserErrorMessage = "This user is deleted";
    }
}
