namespace Guerrero_AppEvaluacion.DG_Views;
[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class DGNotas : ContentPage
{
    public DGNotas()
    {
        InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.DidierGuerrero_notes.txt";

        DG_LoadNote(Path.Combine(appDataPath, randomFileName));
    }
    private async void DG_GuardarButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is DG_models.DG_Nota note) { 
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
    private void DG_LoadNote(string fileName)
    {
        DG_models.DG_Nota noteModel = new DG_models.DG_Nota();
        noteModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }
    public string ItemId
    {
        set { DG_LoadNote(value); }
    }
}