using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace tproNotes.Models
{
    public class proNote
    {
        private string description;
        private DateTime noteDay;
        private string noteType;
        private string noteLocation;
        private decimal totalTTC;
        private decimal totalHT;
        private decimal totalTVA55;
        private decimal totalTVA10;
        private decimal totalTVA15;
        private decimal totalTVA20;
        private List<string> guestsList;

        #region PropertiesGetSet
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime NoteDay
        {
            get { return noteDay; }
            set { noteDay = value; }
        }
        public string NoteType
        {
            get { return noteType; }
            set { noteType = value; }
        }

        public string NoteLocation
        {
            get { return noteLocation; }
            set { noteLocation = value; }
        }

        public decimal TotalTTC
        {
            get { return totalTTC; }
            set { totalTTC = value; }
        }

        public decimal TotalHT
        {
            get { return totalHT; }
            set { totalHT = value; }
        }

        public decimal TotalTVA55
        {
            get { return totalTVA55; }
            set { totalTVA55 = value; }
        }
        public decimal TotalTVA10
        {
            get { return totalTVA10; }
            set { totalTVA10 = value; }
        }

        public decimal TotalTVA15
        {
            get { return totalTVA15; }
            set { totalTVA15 = value; }
        }

        public decimal TotalTVA20
        {
            get { return totalTVA20; }
            set { totalTVA20 = value; }
        }

        public List<string> GuestsList
        {
            get { return guestsList; }
            set { guestsList = value; }
        }
        #endregion

        // The number of each item that has been collected.
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                RaisePropertyChanged("Count");
            }
        }

        // Whether a level has been completed or not
        private bool _completed;
        public bool Completed
        {
            get
            {
                return _completed;
            }
            set
            {
                _completed = value;
                RaisePropertyChanged("Completed");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        // Create a copy of an accomplishment to save.
        // If your object is databound, this copy is not databound.
        public proNote GetCopy()
        {
            proNote copy = (proNote)this.MemberwiseClone();
            return copy;
        }
    }
}
