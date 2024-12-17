using Pienn.ViewModels;
using Pienn.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Pienn
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(NewEntryPage), typeof(NewEntryPage));
            Routing.RegisterRoute(nameof(ReportPage), typeof(ReportPage));
        }
    }
}
