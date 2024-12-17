using Pienn.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
//每當集合項目新增 刪除 被替換 或重新排序時，
//ObservableCollection都會觸發CollestionChanged事件，進而通知ListViwe更動
//ObservableCollection<T> property LogEntries will be used to bind to the ItemSource property of the CollectionView element on MainPage.xaml

//資料變動時通知前端
//接下來要通知Data Binding，參考課本P28
namespace Pienn.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
       ObservableCollection<GoodsEntry> _goodsEntries;
        public ObservableCollection<GoodsEntry> GoodsEntries
        {
            get => _goodsEntries;
            set
            {
                SetProperty(ref _goodsEntries, value);
            }
        }
        ReportEntry _totalEntry;
        public ReportEntry TotalEntry
        {
            get => _totalEntry;
            set
            {
                SetProperty(ref _totalEntry, value);
            }
        }
        public MainViewModel()
        {
            GoodsEntries = Utilities.MockData.GoodsEntries;
            TotalEntry = new ReportEntry();
        }
        int totalmoney;
        public ICommand CaculateCommand
        {
            get
            {
                return new Command(async () =>
                {
                    TotalEntry.Id = Utilities.MockData.ReportEntries.Count+1;
                    foreach (var AN in GoodsEntries)
                        totalmoney += AN.Price * AN.Num;
                    TotalEntry.Money = totalmoney;
                    TotalEntry.Date = DateTime.Now;
                    Utilities.MockData.ReportEntries.Add(TotalEntry);
                    TotalEntry = new ReportEntry();
                    totalmoney = 0;
                    await Shell.Current.DisplayAlert("通知", "儲存成功", "OK");
                    await Shell.Current.GoToAsync("ReportPage");
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
