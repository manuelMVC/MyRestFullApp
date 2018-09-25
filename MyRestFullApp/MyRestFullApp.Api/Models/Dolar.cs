using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Http;

namespace MyRestFullApp.Api.Models
{
    public class Dolar : Moneda
    {
        public override string Cotizar()
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            string dataObject = "Cotización del dolar";
            byte[] data = encoder.GetBytes(dataObject);
            HttpWebRequest request = WebRequest.Create("https://www.bancoprovincia.com.ar/Principal/Dolar") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.GetRequestStream().Write(data, 0, data.Length);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string resp = reader.ReadToEnd();

            return resp;
        }
    }
}