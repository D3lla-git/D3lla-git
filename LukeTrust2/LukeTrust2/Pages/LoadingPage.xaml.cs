using LukeTrust2.Services;

namespace LukeTrust2.Pages;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authService;
	public LoadingPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService ?? throw new ArgumentNullException(nameof(authService));
	}

	protected async override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		if (await _authService.IsAuthenticatedAsync())
		{
			//user is logged in
			//redirect to mainpage
			await Shell.Current.GoToAsync($"//{nameof(Home)}");
		}
		else
		{
			//user not logged in
			//redirect to loginpage
			await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
		}
	}
}
