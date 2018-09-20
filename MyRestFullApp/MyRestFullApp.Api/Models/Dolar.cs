using MyRestFullApp.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace MyRestFullApp.Api.Models
{
    public class Dolar : ICotizacion
    {
        public string Cotizar(string input)
        {
            if (input != "Dolar")
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            HttpWebRequest request = WebRequest.Create("http://www.bancoprovincia.com.ar/Principal/Dolar") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string resp = reader.ReadToEnd();

            return resp;
        }
    }
}