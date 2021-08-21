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
        private bool isSelected;
        public bool IsSelected
        { 
            get => isSelected;
            set
            {
                isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
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
