using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Question : EntityBase
    {
        [BsonElement("id")]
        private string Id { get; set; }

        [BsonElement("question")]
        private string Ask { get; set; }

        [BsonElement("options")]
        private List<string> Options { get; set; }

        [BsonElement("answer")]
        private string Answer { get; set; }

        [BsonElement("asset")]
        private string Asset { get; set; }
    }
}
