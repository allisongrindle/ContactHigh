using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AfterHours.ContactHigh.Domain.Contact;

namespace AfterHours.ContactHigh.Controllers
{
    public class ContactController : ApiController
    {

        IContactRepository _contactRepo;

        public ContactController(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        // GET api/contact
        public IEnumerable<string> Get()
        {
            var contacts = _contactRepo.GetContacts();


            return new string[] { "value1", "value2" };
        }

        // GET api/contact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/contact
        public void Post([FromBody]string value)
        {
        }

        // PUT api/contact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/contact/5
        public void Delete(int id)
        {
        }
    }
}
