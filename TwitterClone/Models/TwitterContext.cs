using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TwitterClone.Models
{
    public class TwitterContext:DbContext
    {
        public DbSet<Follow> Following { get; set; }
        public DbSet<Tweet> Tweetcopy { get; set; }
        public DbSet<Person> user { get; set; }
    }
}