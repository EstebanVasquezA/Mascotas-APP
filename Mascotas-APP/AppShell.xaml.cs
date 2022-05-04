using Mascotas_APP.ViewModels;
using Mascotas_APP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Mascotas_APP
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
