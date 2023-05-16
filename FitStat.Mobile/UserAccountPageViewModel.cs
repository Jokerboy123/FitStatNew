using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Input;

namespace FitStat.Mobile;

public class UserAccountPageViewModel : INotifyPropertyChanged
{
    
        private DateTime _selectedDate;

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                if (value != _selectedDate)
                {
                    _selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


