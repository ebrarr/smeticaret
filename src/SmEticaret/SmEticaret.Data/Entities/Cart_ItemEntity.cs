using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class Cart_ItemEntity : EntityBase
	{
		public int CartId { get; set; }
		public int ProductId { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int Quantity { get; set; }

		//nav prop

		public CartEntity Cart { get; set; }

		public ProductEntity Product { get; set; }
	}

	public class Cart_ItemEntityConfiguration : IEntityTypeConfiguration<Cart_ItemEntity>
	{
		public void Configure(EntityTypeBuilder<Cart_ItemEntity> builder)
		{
            builder.HasOne(c => c.Cart)
                .WithMany(u => u.CartItems)
                .HasForeignKey(c => c.CartId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(c => c.Product)
                .WithMany(u => u.CartItems)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
	}
}
