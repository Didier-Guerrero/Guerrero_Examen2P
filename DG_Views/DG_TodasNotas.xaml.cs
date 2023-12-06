namespace Guerrero_AppEvaluacion.DG_Views;

public partial class DG_TodasNotas : ContentPage
{
	public DG_TodasNotas()
    {
        InitializeComponent();

        BindingContext = new DG_models.DG_AllNotes();
    }
    protected override void OnAppearing()
    {
        ((DG_models.DG_AllNotes)BindingContext).LoadNotes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DGNotas));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (DG_models.DG_Nota)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(DGNotas)}?{nameof(DGNotas.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }
}