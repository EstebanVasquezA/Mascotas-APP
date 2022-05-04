using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas_APP.Models
{
    public partial class Usuario
    {
        public RestRequest request { get; set; }

        const string mimetype = "application/json";
        const string contentType = "Content-Type";

        public Usuario()
        {
            request = new RestRequest();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Contrasenna { get; set; }

        public async Task<bool> ValidarAccesoUsuario()
        {
            bool R = false;

            try
            {
                string RouteSufix = string.Format("Usuarios/ValidarLoginUsuario?pEmail={0}&pContrasenna={1}",
                                                   this.Email, this.Contrasenna);
                string FinalApiRoute = CnnToAPI.ProductionRoute + RouteSufix;

                RestClient client = new RestClient(FinalApiRoute);

                request = new RestRequest(FinalApiRoute, Method.Get);

                //request.AddHeader(CnnToAPI.ApiKeyName, CnnToAPI.ApiKeyValue);
                request.AddHeader(contentType, mimetype);

                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    R = true;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                throw;
            }
            return R;
        }
    }
}
