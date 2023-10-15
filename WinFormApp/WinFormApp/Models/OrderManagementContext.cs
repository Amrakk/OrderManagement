using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace GUI.Models;

public partial class OrderManagementContext : DbContext
{
    public OrderManagementContext()
    {
    }

    public OrderManagementContext(DbContextOptions<OrderManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["default"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustId).HasName("PK__Customer__049E3A89C00DCBC3");

            entity.ToTable("Customer");

            entity.Property(e => e.CustId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CustID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__Item__727E83EB622C127B");

            entity.ToTable("Item");

            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Order__C3905BAF8C5A24EB");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OrderID");
            entity.Property(e => e.CustId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CustID");
            entity.Property(e => e.OrderDate).HasColumnType("date");

            entity.HasOne(d => d.Cust).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustId)
                .HasConstraintName("FK__Order__CustID__3D5E1FD2");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC27A5584E54");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.ItemId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OrderID");

            entity.HasOne(d => d.Item).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__OrderDeta__ItemI__412EB0B6");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__403A8C7D");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CCAC027AC089");

            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
