using System;
using System.Windows;
using System.Collections.ObjectModel;
//using System.IO.IsolatedStorage;
//using Windows.Storage.ApplicationData;
using System.Linq;
using tproNotes.Models;


namespace tproNotes.ViewModel
{
    public class proNotesViewModel
    {
        public ObservableCollection<proNote> proNotes { get; set; }
        private Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

        public void GetproNotes()
        {
            if (localSettings.Values.Where(p => p.GetType() == (new proNote()).GetType()).Count() > 0)
            {
                GetSavedproNotes();
            }
            else
            {
                GetDefaultproNotes();
            }
        }


        public void GetDefaultproNotes()
        {
            ObservableCollection<proNote> a = new ObservableCollection<proNote>();

            // Items to collect
            a.Add(new proNote() { Description = "Potions", NoteType = "Item" });
            a.Add(new proNote() { Description = "Coins", NoteType = "Item" });
            a.Add(new proNote() { Description = "Hearts", NoteType = "Item" });
            a.Add(new proNote() { Description = "Swords", NoteType = "Item" });
            a.Add(new proNote() { Description = "Shields", NoteType = "Item" });

            // Levels to complete
            a.Add(new proNote() { Description = "Level 1", NoteType = "Level" });
            a.Add(new proNote() { Description = "Level 2", NoteType = "Level" });
            a.Add(new proNote() { Description = "Level 3", NoteType = "Level" });

            proNotes = a;
            //MessageBox.Show("Got accomplishments from default");
        }


        public void GetSavedproNotes()
        {
            ObservableCollection<proNote> a = new ObservableCollection<proNote>();

            foreach (Object o in localSettings.Values.Where(p => p.GetType() == (new proNote()).GetType()))
            {
                a.Add((proNote)o);
            }

            proNotes = a;
            //MessageBox.Show("Got accomplishments from storage");
        }
    }
}
