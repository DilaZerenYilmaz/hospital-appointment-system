﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence
{
    public class Entity<TId>
    {
        public TId Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Entity()
        {
            Id = default!;
        }

        public Entity(TId id)
        {
            Id = id;
        }
    }
}
