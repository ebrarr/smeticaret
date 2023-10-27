using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class Product_CommentEntity : EntityBase
	{
		public int ProductId { get; set; }
		public int UserId { get; set; }

		[Required, MaxLength(250)]
		public string Message { get; set; }

		[Required, Range(1, 5)]
		public byte StarCount { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; }
	}
    public class ProductCommentEntityConfiguration : IEntityTypeConfiguration<Product_CommentEntity>
    {
        public void Configure(EntityTypeBuilder<Product_CommentEntity> builder)
        {
            builder.HasOne(pc => pc.Product)
                .WithMany(p => p.ProductComments)
                .HasForeignKey(pc => pc.ProductId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(pc => pc.User)
                .WithMany(u => u.ProductComments)
                .HasForeignKey(pc => pc.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }

}
