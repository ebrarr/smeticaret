using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class CartEntity : EntityBase
	{
		public int UserId { get; set; }

		//nav prop

		[ForeignKey(nameof(UserId))]
		public UserEntity User { get; set; }
	}
}
