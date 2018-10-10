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
        [Route("api/Cotizacion/Dolar")]
        [HttpGet]
        public string CotizarDolar()
        {
            string result = "";
            try
            {
                Contexto contexto = new Contexto(new Dolar());
                result = contexto.Cotizar();
            }
            catch(HttpResponseException ex)
            {
                return ex.Response.ReasonPhrase;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
        [Route("api/Cotizacion/Pesos")]
        [HttpGet]
        public string CotizarPesos()
        {
            string result;
            try
            {
                Contexto contexto = new Contexto(new Pesos());
                result = contexto.Cotizar();
            }
            catch (HttpResponseException ex)
            {
                return ex.Response.ReasonPhrase;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        [Route("api/Cotizacion/Real")]
        [HttpGet]
        public string CotizarReal()
        {
            string result;
            try
            {
                Contexto contexto = new Contexto(new Real());
                result = contexto.Cotizar();
            }
            catch (HttpResponseException ex)
            {
                return ex.Response.ReasonPhrase;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
