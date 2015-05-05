using AfterHours.ContactHigh.Domain.Contact;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterHours.ContactHigh.Infrastructure
{
    public class IoC : NinjectModule
    {
        public override void Load()
        {
            Bind<IContactRepository>().To<MSSQLContactRepository>();
        }
    }
}
