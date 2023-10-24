using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
	public class UserEntity : EntityBase
	{
		public int RoleId { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PasswordHash { get; set; }

	}
}
