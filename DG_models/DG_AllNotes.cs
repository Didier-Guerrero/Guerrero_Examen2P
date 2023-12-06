using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerrero_AppEvaluacion.DG_models
{
    internal class DG_AllNotes
    {
        public ObservableCollection<DG_Nota> Notes { get; set; } = new ObservableCollection<DG_Nota>();

        public DG_AllNotes() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<DG_Nota> notes = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.DidierGuerrero_notes.txt")

                                        // Each file name is used to create a new Note
                                        .Select(filename => new DG_Nota()
                                        {
                                            Filename = filename,
                                            Text = File.ReadAllText(filename),
                                            Date = File.GetCreationTime(filename)
                                        })

                                        // With the final collection of notes, order them by date
                                        .OrderBy(note => note.Date);

            // Add each note into the ObservableCollection
            foreach (DG_Nota note in notes)
                Notes.Add(note);
        }
    }
}
