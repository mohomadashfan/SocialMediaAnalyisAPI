namespace SocialMediaAnalyis.Repository.Contracts
{
    public interface IRepositoryManager
    {
        IFifaTweetRepository FifaTweet { get; }
        Task SaveAsync();
        void Save();
    }
}
