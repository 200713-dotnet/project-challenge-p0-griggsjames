using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBox.Storing
{
    public partial class PizzaBoxDB1Context : DbContext
    {
        public PizzaBoxDB1Context()
        {
        }

        public PizzaBoxDB1Context(DbContextOptions<PizzaBoxDB1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Crust> Crust { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order1> Order1 { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Pizza1> Pizza1 { get; set; }
        public virtual DbSet<PizzaTopping> PizzaTopping { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Topping> Topping { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=PizzaBoxDB1;user id=sa;password=Password12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crust>(entity =>
            {
                entity.ToTable("Crust", "Pizza");

                entity.Property(e => e.CrustId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order", "Order");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Order_StoreId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Order_UserId");
            });

            modelBuilder.Entity<Order1>(entity =>
            {
                entity.HasKey(e => e.StoreOrderId)
                    .HasName("PK__Order__A74CB91AC0EF60D9");

                entity.ToTable("Order", "Store");

                entity.Property(e => e.StoreOrderId).ValueGeneratedNever();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Order1)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Order__OrderId__4CA06362");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Order1)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__StoreId__4BAC3F29");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.PizzaOrderId)
                    .HasName("PK__Pizza__EA09DF5D6FE90D7F");

                entity.ToTable("Pizza", "Order");

                entity.Property(e => e.PizzaOrderId)
                    .HasColumnName("PizzaOrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Pizza__OrderID__4F7CD00D");

                entity.HasOne(d => d.PizzaNavigation)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__Pizza__PizzaID__5070F446");
            });

            modelBuilder.Entity<Pizza1>(entity =>
            {
                entity.HasKey(e => e.PizzaId)
                    .HasName("PK_Pizza_PizzaId");

                entity.ToTable("Pizza", "Pizza");

                entity.Property(e => e.PizzaId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Crust)
                    .WithMany(p => p.Pizza1)
                    .HasForeignKey(d => d.CrustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Pizza_CrustId");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Pizza1)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Pizza_SizeId");
            });

            modelBuilder.Entity<PizzaTopping>(entity =>
            {
                entity.ToTable("PizzaTopping", "Pizza");

                entity.Property(e => e.PizzaToppingId)
                    .HasColumnName("PizzaToppingID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.ToppingId).HasColumnName("ToppingID");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.PizzaTopping)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__PizzaTopp__Pizza__534D60F1");

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.PizzaTopping)
                    .HasForeignKey(d => d.ToppingId)
                    .HasConstraintName("FK__PizzaTopp__Toppi__5441852A");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size", "Pizza");

                entity.Property(e => e.SizeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store", "Store");

                entity.Property(e => e.StoreId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<Topping>(entity =>
            {
                entity.ToTable("Topping", "Pizza");

                entity.Property(e => e.ToppingId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C9F30ABF6");

                entity.ToTable("Users", "Users");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
