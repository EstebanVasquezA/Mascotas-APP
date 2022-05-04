using Mascotas_APP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mascotas_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        UsuarioViewModel Vm;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new UsuarioViewModel();
        }

        public void CmdSeePassword(object sender, ToggledEventArgs e)
        {
            if (SwSeePassword.IsToggled)
            {
                TxtPassword.IsPassword = false;
            }
            else
            {
                TxtPassword.IsPassword = true;
            }
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            bool R = await Vm.ValidarAccesoUsuario(TxtUsername.Text.Trim(), TxtPassword.Text.Trim());

            if (R)
            {
                await DisplayAlert("Info", "Acceso Permitido!", "OK");

                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                await DisplayAlert("Error", "Email o Contraseña Incorrecta!", "OK");
                TxtPassword.Focus();
            }
        }
    }
}