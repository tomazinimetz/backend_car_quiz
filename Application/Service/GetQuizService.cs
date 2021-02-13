using Domain.Entities;
using Infra.Repositories;

namespace Application.Service
{
    public sealed class GetQuizService : IGetService<Quiz>
    {
        private readonly IGetRepository<Quiz> _repository;

        public GetQuizService() { }
        public GetQuizService(IGetRepository<Quiz> repository)
        {
            _repository = repository;
        }

        public Quiz Get() => _repository.Get();
    }
}
