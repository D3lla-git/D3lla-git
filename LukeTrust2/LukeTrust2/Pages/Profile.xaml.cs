using LukeTrust2.Services;

namespace LukeTrust2.Pages;

public partial class Profile : ContentPage
{
	private readonly AuthService _authService;

	public Profile(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		_authService.Logout();
		Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
	}
}
