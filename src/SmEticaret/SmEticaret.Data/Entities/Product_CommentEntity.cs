using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class Product_CommentEntity : EntityBase
	{
		public int ProductId { get; set; }
		public int UserId { get; set; }
		public string Message { get; set; }
		public byte StarCount { get; set; }
	}
}
