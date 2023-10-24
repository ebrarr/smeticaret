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

		[ForeignKey(nameof(OrderId))]
		public OrderEntity Order { get; set; }

		[ForeignKey(nameof(ProductId))]
		public ProductEntity Product { get; set; }
	}
}
