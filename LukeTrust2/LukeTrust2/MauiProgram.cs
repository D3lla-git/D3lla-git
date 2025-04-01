using Firebase.Auth;
using Firebase.Auth.Providers;
using LukeTrust2.Pages;
using LukeTrust2.Services;
using Microsoft.Extensions.Logging;

namespace LukeTrust2
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif


			builder.Services.AddTransient<AuthService>();
			builder.Services.AddTransient<LoadingPage>();
			builder.Services.AddTransient<LoginPage>();
			builder.Services.AddTransient<Profile>();
			//builder.Services.AddSingleton(new Firebase.Auth.FirebaseAuthClient(new FirebaseAuthConfig()


			//{
			//	ApiKey = "\r\nAIzaSyBPQhHTTka-lwrESsptC9kVdIuVQFa75Fg",
			//	AuthDomain = "luketrust2.firebaseapp.com",
			//	Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
			//	 {
			//	new EmailProvider()
			//	}
			//}
			//));

			//builder.Services.AddSingleton<Signinview>();
			//builder.Services.AddSingleton<SigninViewmodel>();
			//builder.Services.AddSingleton<Signupview>();
			//builder.Services.AddSingleton<SignupViewModel>();

			return builder.Build();
		}
	}
}
