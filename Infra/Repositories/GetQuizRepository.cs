using Domain.Entities;
using Infra.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositories
{
    public sealed class GetQuizRepository : RepositoryBase, IGetRepository<Quiz>
    {
        public GetQuizRepository() : base() { }
        public GetQuizRepository(IDatabaseSettings settings) : base(settings) { }

        public Quiz Get()
        {
            var response = _quizCollection.Find(quiz => true).FirstOrDefault();
            return response;
        }
    }
}
