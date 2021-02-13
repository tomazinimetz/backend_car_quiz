using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Quiz : EntityBase
    {
        [BsonElement("questions")]
        private List<Question> Questions { get; set; }

        [BsonElement("current_question")]
        private int CurrentQuestion { get; set; }
    }
}
