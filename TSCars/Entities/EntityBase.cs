﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCars.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}
