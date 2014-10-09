using System;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using System.Collections.Generic;

namespace OwinKatanaWebApiSample
{
    public class ValuesController: ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try 
            { 
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "valueOne", "valueTwo" });
            }
            catch(Exception ex)
            { 
                return Request.CreateResponse(HttpStatusCode.InternalServerError , ex); 
            }
        }

        [HttpGet]
        public HttpResponseMessage Value(int id)
        {
            try 
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Value" + id);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex); 
            }
        }
    }
}
