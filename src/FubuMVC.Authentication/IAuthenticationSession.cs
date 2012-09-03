namespace FubuMVC.Authentication
{
    public interface IAuthenticationSession
    {
        void MarkAccessed();
        string PreviouslyAuthenticatedUser();
        void MarkAuthenticated(string userName);
        void ClearAuthentication();
    }
}