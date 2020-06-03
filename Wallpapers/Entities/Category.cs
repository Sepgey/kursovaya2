using System;
using System.Collections;
using System.Collections.Generic;

namespace Wallpapers.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Category() : base()
        {

        }

        public Category(int id, string name, string description) : base(id)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }


}