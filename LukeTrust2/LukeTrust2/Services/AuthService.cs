using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeTrust2.Services
{
    public class AuthService
    {
		private const string AuthStateKey = "AuthState";
		public async Task<bool> IsAuthenticatedAsync() 
        {
            await Task.Delay(2000);

			var authState = Preferences.Default.Get<bool>(AuthStateKey, false);
			return authState;

		}
        public void Login()
        {
			//login logic
			Preferences.Default.Set<bool>(AuthStateKey, true);
		}
		public void Logout()
		{
			//logout logic
			Preferences.Default.Remove(AuthStateKey);
		}
	}
}
