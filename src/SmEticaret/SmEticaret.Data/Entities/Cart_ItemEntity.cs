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

		[ForeignKey(nameof(CartId))]
		public CartEntity Cart { get; set; }

		[ForeignKey(nameof(ProductId))]
		public ProductEntity Product { get; set; }
	}
}
