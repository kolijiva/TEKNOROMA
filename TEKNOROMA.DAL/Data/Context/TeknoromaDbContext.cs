using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TEKNOROMA.DAL.Data.SeedData;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.Context
{
    public class TeknoromaDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public TeknoromaDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(s => s.Supplier)
                .WithMany(p => p.Products)
                .HasForeignKey(s => s.SupplierID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(c => c.CustomerID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Order)
                .WithMany(oi => oi.OrderItems)
                .HasForeignKey(o => o.OrderID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(s => s.Store)
                .WithMany(e => e.Employees)
                .HasForeignKey(s => s.StoreID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Category>().HasData(CategorySeed.categories);
            modelBuilder.Entity<Supplier>().HasData(SupplierSeed.suppliers);
            modelBuilder.Entity<Product>().HasData(ProductSeed.products);
            modelBuilder.Entity<Customer>().HasData(CustomerSeed.customers);
            modelBuilder.Entity<Store>().HasData(StoreSeed.stores);
            modelBuilder.Entity<Employee>().HasData(EmployeeSeed.employees);
            modelBuilder.Entity<Order>().HasData(OrderSeed.orders);
            modelBuilder.Entity<OrderItem>().HasData(OrderItemSeed.orderItems);
            modelBuilder.Entity<ServiceRequest>().HasData(ServiceRequestSeed.serviceRequests);
            modelBuilder.Entity<Expense>().HasData(ExpenseSeed.expenses);
            modelBuilder.Entity<Invoice>().HasData(InvoiceSeed.invoices);
        }
    }
}
