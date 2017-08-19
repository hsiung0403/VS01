using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBAccess;


namespace WebAPI.Controllers
{
    public class ChiController : ApiController
    {
        [HttpPost]
        [Route("api/Chi/UpdatDepart")]
        public void UpdatDepart([FromBody]DataTable dt)
        {
            int i = 0;
            try
            {
                WebAPI.Models.UpdateAccount.updateDept(dt);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        
        }
        [Route("api/Chi/UpdateCustomer")]
        public void UpdateCustomer([FromBody]DataTable dt)
        {
            int i = 0;
            try
            {
                WebAPI.Models.UpdateAccount.updateCustomer(dt);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}