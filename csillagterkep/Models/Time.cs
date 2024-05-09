﻿using System;
using System.Collections.Generic;

namespace csillagterkep.Models
{
    public partial class Time
    {
        public Time()
        {
            Lessons = new HashSet<Lesson>();
        }

        public byte TimeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
