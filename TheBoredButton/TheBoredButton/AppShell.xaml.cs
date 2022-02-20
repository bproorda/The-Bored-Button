using System;
using System.Collections.Generic;
using TheBoredButton.ViewModels;
using TheBoredButton.Views;
using Xamarin.Forms;

namespace TheBoredButton
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
