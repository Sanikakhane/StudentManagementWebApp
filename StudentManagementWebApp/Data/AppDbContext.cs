using Microsoft.EntityFrameworkCore;

namespace StudentManagementWebApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(new Student(1, "John", 20, new List<int> { 85, 90, 78 }));
            modelBuilder.Entity<Student>().HasData(new Student(2, "Alice", 22, new List<int> { 92, 88, 94 }));
            modelBuilder.Entity<Student>().HasData(new Student(3, "Bob", 21, new List<int> { 75, 80, 70 }));
            modelBuilder.Entity<Student>().HasData(new Student(4, "Charlie", 23, new List<int> { 65, 70, 80 }));
            modelBuilder.Entity<Student>().HasData(new Student(5, "David", 24, new List<int> { 88, 90, 85 }));
            modelBuilder.Entity<Student>().HasData(new Student(6, "Eve", 19, new List<int> { 78, 82, 80 }));
            modelBuilder.Entity<Student>().HasData(new Student(7, "Frank", 20, new List<int> { 92, 95, 91 }));
            modelBuilder.Entity<Student>().HasData(new Student(8, "Grace", 22, new List<int> { 70, 72, 68 }));
            modelBuilder.Entity<Student>().HasData(new Student(9, "Hannah", 21, new List<int> { 90, 88, 85 }));
            modelBuilder.Entity<Student>().HasData(new Student(10, "Ivy", 23, new List<int> { 80, 85, 78 }));
            
        }


    }
}
