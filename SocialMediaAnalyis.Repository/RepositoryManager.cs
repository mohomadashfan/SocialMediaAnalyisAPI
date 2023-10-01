using SocialMediaAnalyis.Repository.Contracts;

namespace SocialMediaAnalyis.Repository
{
    public partial class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;

        private readonly Lazy<IFifaTweetRepository> _fifaTweetRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _fifaTweetRepository = new Lazy<IFifaTweetRepository>(() => new FifaTweetRepository(repositoryContext));
        }

        public IFifaTweetRepository FifaTweet => _fifaTweetRepository.Value;

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
