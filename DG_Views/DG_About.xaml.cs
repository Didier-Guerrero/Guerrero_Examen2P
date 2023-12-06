namespace Guerrero_AppEvaluacion.DG_Views;

public partial class DG_About : ContentPage
{
	public DG_About()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is DG_models.DG_Acerca about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}