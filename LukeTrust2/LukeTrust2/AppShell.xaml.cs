using LukeTrust2.Pages;

namespace LukeTrust2
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(Dialects), typeof(Dialects));
			Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
			Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
			Routing.RegisterRoute(nameof(Home), typeof(Home));
			Routing.RegisterRoute(nameof(Profile), typeof(Profile));
		}
	}
}
