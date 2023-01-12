

namespace BitirmeTezi.Authentication
{
	public class UserAccountService
	{
		private List<UserAccount> _users;
		public UserAccountService()
		{

			_users = new List<UserAccount>
			{
				new UserAccount {UserName="Admin",Password="Admin",Role="administration"}
			};
		}
		

		public UserAccount? GetByUserName(string userName)
		{ 
			return _users.FirstOrDefault(x => x.UserName == userName);
		}
	}

	
	
}
