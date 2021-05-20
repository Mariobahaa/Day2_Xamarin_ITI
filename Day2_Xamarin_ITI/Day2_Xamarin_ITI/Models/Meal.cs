using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;
using SQLitePCL;

namespace Day2_Xamarin_ITI.Models
{
    public class Meal: INotifyPropertyChanged
    {
        
        private string name;
        [PrimaryKey, MaxLength(100)]
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

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                if (image == value) return;
                image = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Image"));
            }
        }

        private decimal price;
        [NotNull]

        public decimal Price
        {
            get { return price ; }
            set
            {
                if (price == value) return;
                price = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
