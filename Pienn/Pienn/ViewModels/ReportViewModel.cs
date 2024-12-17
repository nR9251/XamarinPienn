using Pienn.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pienn.ViewModels
{
    public class ReportViewModel : MainViewModel
    {
        ObservableCollection<ReportEntry> _reportEntries;
        public ObservableCollection<ReportEntry> ReportEntries
        {
            get => _reportEntries;
            set
            {
                SetProperty(ref _reportEntries, value);
            }
        }
        public ReportViewModel()
        {
            ReportEntries = Utilities.MockData.ReportEntries;
        }
        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
