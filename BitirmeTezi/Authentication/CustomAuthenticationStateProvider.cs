using Entitylayer.Concrete;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace BitirmeTezi.Authentication
{
	public class CustomAuthenticationStateProvider : AuthenticationStateProvider
	{

		private readonly ProtectedSessionStorage _sesionStroage;
		private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());
		public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
		{
			_sesionStroage = sessionStorage;
		}
		public override async Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			try
			{
                var userSessionStorageResault = await _sesionStroage.GetAsync<UserSession>("UserSession");
                var userSession = userSessionStorageResault.Success ? userSessionStorageResault.Value : null;
                if (userSession == null) { return await Task.FromResult(new AuthenticationState(_anonymous)); }
                
                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, userSession.UserName),
				new Claim(ClaimTypes.Role, userSession.Role)
            }, "CustomAuth"));
                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }
			catch
			{
				return await Task.FromResult(new AuthenticationState(_anonymous));
			}
			

		}
		public async Task UpdateAuthenticationState(UserSession userSession)
		{
			ClaimsPrincipal claimsPrincipal;
			if(userSession != null)
			{
				await _sesionStroage.SetAsync("UserSession", userSession);
				claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
				{
					new Claim(ClaimTypes.Name, userSession.UserName),

                    new Claim(ClaimTypes.Role, userSession.Role)
                }));
			}
			else
			{
				await _sesionStroage.DeleteAsync("UserSession");
				claimsPrincipal = _anonymous;
			}
			NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
		}
	}
}
