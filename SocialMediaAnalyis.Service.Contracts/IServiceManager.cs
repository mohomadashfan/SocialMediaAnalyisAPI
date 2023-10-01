namespace SocialMediaAnalyis.Service.Contracts
{
    public interface IServiceManager
    {
        ISocialUsersService UsersService { get; }
        IFifaTweetService TweetService { get; }

    }
}