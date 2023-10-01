namespace SocialMediaAnalyis.Repository.Contracts
{
    public interface IRepositoryManager
    {
        ISocialUsersRepository SocialUsers { get; }
        IFifaTweetRepository FifaTweet { get; }
        Task SaveAsync();
        void Save();
    }
}
