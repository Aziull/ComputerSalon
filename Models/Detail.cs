using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Models
{
    public class Detail : INotifyPropertyChanged
    {
        private bool isSellected;
        public bool IsSellected
        { 
            get => isSellected;
            set
            {
                isSellected = value;
                OnPropertyChanged(nameof(IsSellected));
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DetailType Type { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
