namespace Guerrero_AppEvaluacion;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(DG_Views.DGNotas), typeof(DG_Views.DGNotas));
    }
}
