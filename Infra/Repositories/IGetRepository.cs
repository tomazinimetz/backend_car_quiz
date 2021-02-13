using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositories
{
    public interface IGetRepository<T> where T : EntityBase
    {
        T Get();
    }
}
