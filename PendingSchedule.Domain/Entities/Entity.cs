using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendingSchedule.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
