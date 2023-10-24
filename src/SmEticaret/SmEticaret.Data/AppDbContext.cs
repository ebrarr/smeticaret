using Microsoft.EntityFrameworkCore;
using SmEticaret.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserEntity> Users { get; set; }
		public DbSet<RoleEntity> Roles { get; set; }
		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<Product_CommentEntity> ProductComments { get; set; }
		public DbSet<OrderEntity> Orders { get; set; }
		public DbSet<Order_ItemEntity> OrderItems { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<CartEntity> Carts { get; set; }
		public DbSet<Cart_ItemEntity> CartItems { get; set; }
	}
}
