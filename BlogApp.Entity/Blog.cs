﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entity
{
    class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string img { get; set; }
        public DateTime Date { get; set; }
        public bool isApproved { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
