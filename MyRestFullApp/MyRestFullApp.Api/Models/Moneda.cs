using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRestFullApp.Api.Models
{
    public abstract class Moneda
    {
        public abstract string Cotizar();
    }
}