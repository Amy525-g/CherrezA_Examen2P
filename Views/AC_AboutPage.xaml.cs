using System.Reflection;

namespace CherrezA_Examen2P.Views;

public partial class AC_AboutPage : ContentPage
{
	public AC_AboutPage()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.AC_About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}