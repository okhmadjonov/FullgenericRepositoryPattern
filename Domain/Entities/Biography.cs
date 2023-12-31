﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Biography
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;
        public Actor? Actor { get; set; }

        //[ForeignKey("ActorId")]
        public int ActorId { get; set; }
    }
}
