using Domain.Entities;

namespace Application.Service
{
    public interface IGetService<T> where T : EntityBase
    {
        T Get();
    }
}
