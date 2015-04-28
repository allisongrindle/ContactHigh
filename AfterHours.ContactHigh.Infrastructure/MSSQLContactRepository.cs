using AfterHours.ContactHigh.Domain.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterHours.ContactHigh.Infrastructure
{
    public class MSSQLContactRepository : IContactRepository
    {
        public List<Contact> GetContacts()
        {
            throw new NotImplementedException();
        }
    }
}
