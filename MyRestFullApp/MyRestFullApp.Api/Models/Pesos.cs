using MyRestFullApp.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyRestFullApp.Api.Models
{
    public class Pesos : ICotizacion
    {
        public string Cotizar(string input)
        {
            throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}