using Domain.Entities;
using Infra.Settings;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly IMongoCollection<Quiz> _quizCollection;

        protected RepositoryBase()
        {
        }

        protected RepositoryBase(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _quizCollection = database.GetCollection<Quiz>(settings.CollectionName);
        }
    }
}
