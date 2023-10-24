using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class OrderEntity : EntityBase
	{
		public int UserId { get; set; }
		public DateTime CreatedAt { get; set; }
		public string DeliveryAddress { get; set; }

		//nav prop

		[ForeignKey(nameof(UserId))]
		public UserEntity User { get; set; }
	}
}
