using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace my_PNET_PR3_1_Z3
{
    public class Modify_Movies : INotifyPropertyChanged
    {
        private string _title;
        private string _director;
        private string _producer;
        private string _dataCT;
        private DateTime? _releaseDate;
        public event PropertyChangedEventHandler? PropertyChanged;
        private static Dictionary<string, ICollection<string>> Properties =
        new Dictionary<string, ICollection<string>>()
        {
            ["Title"] = new string[] { "_title" },
            ["Director"] = new string[] { "_director" },
            ["Producer"] = new string[] { "_producer" },
            ["DataCT"] = new string[] { "_dataCT" },
            ["ReleaseDate"] = new string[] { "_releaseDate" }
        };

        void OnPropertyChanged(
            [CallerMemberName] string? propertyName = null,
            HashSet<string> done = null
            )
        {
            if (done == null)
                done = new();
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName)
                );
            done.Add(propertyName);
            if (Properties.ContainsKey(propertyName))
                foreach (string property in Properties[propertyName])
                    if (done.Contains(property) == false)
                        OnPropertyChanged(property, done);
        }
        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value;
                OnPropertyChanged();
            }
        }
        public string Director
        {
            get { return _director; }
            set
            {
                _director = value;
                OnPropertyChanged();
            }
        }
        public string Producer 
        {
            get { return _producer; }
            set
            {
                _producer = value;
                OnPropertyChanged();
            }
        }
        public DateTime? ReleaseDate
        {
            get { return _releaseDate; }
            set
            {
                _releaseDate = value;
                OnPropertyChanged();
            }
        }
        public string DataCT
        {
            get { return _dataCT; }
            set 
            {
                _dataCT = value;
                OnPropertyChanged();
            }
        }
    }
}
