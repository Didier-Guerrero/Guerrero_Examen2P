namespace Guerrero_AppEvaluacion.DG_Views;

public partial class DG_Conteo : ContentPage
{
	public DG_Conteo()
	{
		InitializeComponent();
	}
    private async void DG_GuardarButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is DG_models.DG_Nota note)
        {
            File.WriteAllText(note.Filename, TextEditor.Text);
        }
        await Shell.Current.GoToAsync("..");
    }

    private async void DG_EliminarButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is DG_models.DG_Nota note)
        {
            // Delete the file.
            if (File.Exists(note.Filename))
                File.Delete(note.Filename);
        }

        await Shell.Current.GoToAsync("..");
    }
}