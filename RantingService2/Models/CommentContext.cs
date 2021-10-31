using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RantingService2.Models
{
    public class CommentContext : DbContext
    {
        public CommentContext() : base("RatingServiceDb")
        {

        }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}