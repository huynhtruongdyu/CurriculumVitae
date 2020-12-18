using System;

namespace CurriculumViate.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateOnUtc { get; set; }
        public DateTime? UpdateOnUtc { get; set; }
        public Status Status { get; set; }
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