using Pienn.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pienn.Utilities
{
    public class MockData
    {
        public static ObservableCollection<GoodsEntry> GoodsEntries =
            new ObservableCollection<GoodsEntry>()
        {
            new GoodsEntry()
                {
                    Id = 1,
                    Title = "Verbrechen und Bestrafung",
                    Source = "vb.png",
                    Price = 200,
                    Num = 0,
                    Remark = "https://www.doujin.com.tw/books/info/46198"
                },
            new GoodsEntry()
                {
                    Id = 2,
                    Title = "晝",
                    Source = "hiru.png",
                    Price = 2499,
                    Num = 0,
                    Remark = " "
                }
        };
        public static ObservableCollection<ReportEntry> ReportEntries = 
            new ObservableCollection<ReportEntry>()
        {
            new ReportEntry()
            {
                Id= 1,
                Date = new DateTime(2022,7,5,12,2,46),
                Money = 2699
            },
            new ReportEntry()
            {
                Id= 2,
                Date = new DateTime(2022,7,6,15,34,43),
                Money = 600
            }
        };
    }
}
