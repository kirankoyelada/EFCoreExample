﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCDemo.Models
{
    public partial class ActorDbContext : DbContext
    {
        public virtual DbSet<Actors> Actors { get; set; }

        public ActorDbContext(DbContextOptions<ActorDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
