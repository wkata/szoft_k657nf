﻿using System;
using System.Collections.Generic;

namespace csillagterkep.Models
{
    public partial class Status
    {
        public Status()
        {
            Instructors = new HashSet<Instructor>();
        }

        public byte StatusId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
