using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mascotas_APP.ViewModels;

namespace Mascotas_APP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void BtnMascotas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MascotasPage());
        }
    }
}