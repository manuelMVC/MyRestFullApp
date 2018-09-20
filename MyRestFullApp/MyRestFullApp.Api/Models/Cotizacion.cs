using MyRestFullApp.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRestFullApp.Api.Models
{
    public class Cotizacion
    {
        ICotizacion cotizacion;
        public Cotizacion() { }
        internal Cotizacion(ICotizacion cotizacion)
        {
            this.cotizacion = cotizacion;
        }

        public string Cotizar(string input)
        {
            var result = input;
            result += cotizacion.Cotizar(input);
            return result;
        }

    }
}