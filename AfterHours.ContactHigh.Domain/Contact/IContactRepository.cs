using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterHours.ContactHigh.Domain.Contact
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();

    }
}
