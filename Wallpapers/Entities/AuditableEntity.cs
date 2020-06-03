using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    public abstract class AuditableEntity : Entity
    {
        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public AuditableEntity() : base()
        {

        }

        public AuditableEntity(int id) : base(id)
        {

        }
    }
}
