using System.Web.Http;

namespace MyRestFullApp.Api.Models
{
    public class Real : Moneda
    {

        public override string Cotizar()
        {
            throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}