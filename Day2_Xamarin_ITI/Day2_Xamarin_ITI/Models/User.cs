using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Day2_Xamarin_ITI.Models
{
    public class User: INotifyPropertyChanged
    {
        private string username;
        [PrimaryKey]
        public string Username
        {
            get { return username; }
            set
            {
                if (username == value) return;
                username = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Username"));
            }

        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password == value) return;
                password = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Password"));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
