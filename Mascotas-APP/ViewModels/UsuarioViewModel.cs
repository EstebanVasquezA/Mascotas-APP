using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mascotas_APP.Models;

namespace Mascotas_APP.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        public Usuario MiUsuario { get; set; }

        public UsuarioViewModel()
        {
            MiUsuario = new Usuario();
        }

        public async Task<bool> ValidarAccesoUsuario(string pEmail, string pContrasenna)
        {
            if (IsBusy)
            {
                return false;
            }
            IsBusy = true;

            try
            {
                MiUsuario.Email = pEmail;
                MiUsuario.Contrasenna = pContrasenna;

                bool R = await MiUsuario.ValidarAccesoUsuario();

                return R;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
