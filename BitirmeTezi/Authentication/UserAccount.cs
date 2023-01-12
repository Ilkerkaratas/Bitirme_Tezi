using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeTezi.Authentication
{
	public class UserAccount
	{
	
		public string UserName { get; set; }
		public string Role { get; set; }
		public string Password { get; set; }
	}
}
