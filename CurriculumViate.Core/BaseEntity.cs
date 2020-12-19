using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CurriculumViate.Core
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreateOnUtc { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? UpdateOnUtc { get; set; }

        public Status Status { get; set; 
        
        public BaseEntity()
        {
            this.CreateOnUtc  = DateTime.UtcNow;
            this.Status = Status.Active;
        }
    }

    public enum Status
    {
        InActive,
        Active
    }
}