using System.Threading.Tasks;
using LukeTrust2.Services;
using Microsoft.Maui.Controls;

namespace LukeTrust2.Pages;

public partial class LoginPage : ContentPage
{
	private readonly AuthService _authService;

	public LoginPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		_authService.Login();
		Shell.Current.GoToAsync($"//{nameof(Home)}");
	}
}
