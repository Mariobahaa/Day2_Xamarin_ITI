using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Day2_Xamarin_ITI.Models
{
    public class Player: INotifyPropertyChanged
    {
     
        private int id;

        [PrimaryKey]
        public int Id
        {
            get { return id; }
            set
            {
                if (id == value) return;
                id = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Id"));
            }
        }


        private string name;
        [MaxLength(30), NotNull]
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private int clubId;

        [NotNull]
        public int ClubId
        {
            get { return clubId; }
            set
            {
                if (clubId == value) return;
                clubId = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ClubId"));
            }
        }

        private int shirtNumber;
        [NotNull]

        public int ShirtNumber
        {
            get { return shirtNumber ; }
            set
            {
                if (shirtNumber == value) return;
                shirtNumber = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ShirtNumber"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
