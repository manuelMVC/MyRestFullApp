using System.Web.Http;

namespace MyRestFullApp.Api.Models
{

    public class Pesos : Moneda
    {
        public override string Cotizar()
        {
            throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}