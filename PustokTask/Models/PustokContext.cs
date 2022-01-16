﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTask.Models
{
    public class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Genre> Genres { get; set; }


    }
}