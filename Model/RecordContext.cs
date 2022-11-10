using Microsoft.EntityFrameworkCore;
using MyRecordApp.Model.Entities;
using System;

namespace MyRecordApp.Model
{
    public class RecordContext : DbContext
    {
        public DbSet<Label> Labels { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Record> Records { get; set; }

        public string DbPath { get; }

        public RecordContext()
        {
            var folder = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Join(folder, "collection.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}

