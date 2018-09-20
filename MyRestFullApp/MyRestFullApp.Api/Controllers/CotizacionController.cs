using MyRestFullApp.Api.Interfaces;
using MyRestFullApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyRestFullApp.Api.Controllers
{
    public class CotizacionController : ApiController
    {
        ICotizacion cotizador;
        internal CotizacionController(ICotizacion cotizador)
        {
            this.cotizador = cotizador;
        }
        [HttpGet]
        [Route("Cotizacion/{Moneda}")]
        public string Cotizar(string Moneda)
        {
            var result = new Cotizacion();
            return result.Cotizar(Moneda);
        }
    }
}
