using Microsoft.EntityFrameworkCore;
using OutBrain.Models;

namespace OutBrain.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DocumentsCategory> DocumentsCategories {get; set;}
        public DbSet<DocumentsEntity> DocumentsEntities {get; set;}
        public DbSet<DocumentsMeta> DocumentsMetas {get; set;}
        public DbSet<DocumentsTopic> DocumentsTopics { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Click> Clicks { get; set; }

        public DbSet<PageView> PageViews { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("filename =./OutBrain.db");
        }
    }
}