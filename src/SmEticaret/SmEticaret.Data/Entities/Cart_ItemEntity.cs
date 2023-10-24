using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class Cart_ItemEntity : EntityBase
	{
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
	}
}
