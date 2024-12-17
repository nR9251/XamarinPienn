
using Pienn.Models;
using Pienn.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pienn.ViewModels
{
    public class NewEntryViewModel : MainViewModel
    {

        GoodsEntry _newEntry;
        public GoodsEntry NewEntry
        {
            get => _newEntry;
            set
            {
                SetProperty(ref _newEntry, value);
            }
        }

        public NewEntryViewModel()
        {
            NewEntry = new GoodsEntry();
        }
        public ICommand SaveCommand
        {
            get
            {
                return new Command(async () =>
                {
                    NewEntry.Id = Utilities.MockData.GoodsEntries.Count + 1;
                    Utilities.MockData.GoodsEntries.Add(NewEntry);
                    NewEntry = new GoodsEntry();
                    await Shell.Current.DisplayAlert("通知","儲存成功", "OK");
                });
            }
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
