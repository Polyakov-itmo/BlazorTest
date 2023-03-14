﻿using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Todo : IdModel
    {
        public string Text { get; set; }
        public bool IsDone { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
