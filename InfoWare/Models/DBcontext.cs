namespace InfoWare.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<FQA> FQAs { get; set; }
        public virtual DbSet<MainCategory> MainCategories { get; set; }
        public virtual DbSet<OrdersNumber> OrdersNumbers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Roll> Rolls { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<SubSubCategory> SubSubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FQA>()
                .Property(e => e.FeadBack)
                .IsFixedLength();

            modelBuilder.Entity<FQA>()
                .Property(e => e.Reply)
                .IsFixedLength();

            modelBuilder.Entity<MainCategory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<MainCategory>()
                .HasOptional(e => e.MainCategory1)
                .WithRequired(e => e.MainCategory2);

            modelBuilder.Entity<MainCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.MainCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MainCategory>()
                .HasMany(e => e.SubCategories)
                .WithRequired(e => e.MainCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdersNumber>()
                .Property(e => e.CaseProducts)
                .IsFixedLength();

            modelBuilder.Entity<OrdersNumber>()
                .Property(e => e.PayType)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.PNumber)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Specs)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.FQA)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<Roll>()
                .Property(e => e.NameRoll)
                .IsFixedLength();

            modelBuilder.Entity<Roll>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roll)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubCategory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.SubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.SubSubCategories)
                .WithRequired(e => e.SubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubSubCategory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SubSubCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.SubSubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Adress)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.FQAs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OrdersNumbers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
