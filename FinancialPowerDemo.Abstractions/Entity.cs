using System;

namespace FinancialPowerDemo.Abstractions
{
    public class Entity : Entity<Guid>
    {
    }

    public class Entity<TId> : IEntity
    {
        public virtual TId Id { get; set; }
    }
}
