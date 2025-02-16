﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models
{
    public class Comment : Entity
    {
        public string Description { get; set; }
        public virtual User User { get; set; }//bir yorum bir user tarafından yapılabilir
        public virtual Blog Blog { get; set; }//Bir comment bir bloga ait olabilir
    }
}
