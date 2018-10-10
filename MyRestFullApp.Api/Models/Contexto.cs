using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRestFullApp.Api.Models
{
    public class Contexto
    {
        private Moneda _moneda;

        public Contexto(Moneda moneda)
        {
            this._moneda = moneda;
        }
        public string Cotizar()
        {
            var result = "";
            result += _moneda.Cotizar();
            return result;
        }
    }
}