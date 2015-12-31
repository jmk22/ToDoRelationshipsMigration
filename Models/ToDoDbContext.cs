using Microsoft.Data.Entity;

namespace ToDoRelationships.Models
{
    public class ToDoDbContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}
