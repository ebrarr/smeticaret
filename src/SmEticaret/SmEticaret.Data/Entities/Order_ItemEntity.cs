using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class Order_ItemEntity : EntityBase
	{
		public int OrderId { get; set; }
		public int ProductId { get; set; }

		[Required, Range(1, int.MaxValue )]
		public int Quantity { get; set; }

		[Required, Range(0, double.MaxValue), DataType(DataType.Currency)]
		public decimal Paid { get; set; }

		//nav prop

		public OrderEntity Order { get; set; }

		public ProductEntity Product { get; set; }
	}

    public class Order_ItemEntityConfiguraton : IEntityTypeConfiguration<Order_ItemEntity>
    {
        public void Configure(EntityTypeBuilder<Order_ItemEntity> builder)
        {
            builder.HasOne(c => c.Order)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(c => c.OrderId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(c => c.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(c => c.OrderId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
