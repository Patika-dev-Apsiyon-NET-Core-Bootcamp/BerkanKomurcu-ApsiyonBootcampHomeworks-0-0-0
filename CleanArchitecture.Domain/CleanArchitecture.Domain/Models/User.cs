﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }//bir comment birden fazla usera ait olabilir
        public virtual ICollection<Blog> Blogs { get; set; }//birden fazla blog bir usera ait olabilir
    }
}
