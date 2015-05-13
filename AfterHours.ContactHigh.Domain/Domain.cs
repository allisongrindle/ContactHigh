using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterHours.ContactHigh.Domain
{
    public interface IAppService
    {
        Person GetPerson(int id);
        List<Person> GetPeople();
        Confirmation AddPerson(Person person); // Adds the new contact and sets up recurring reminders based on frequency
        Confirmation EditPerson(Person person); // Validates all fields and runs specific logic based on which fields changed
        Confirmation DeletePerson(int id);

        List<Interaction> GetInteractions(object query);
        Interaction GetInteraction(int id);
        Confirmation CreateInteraction(Reminder reminder); // Creates an interaction and closes/dismisses/??? reminder
        Confirmation AddInteraction(Interaction interaction);
        Confirmation EditInteraction(Interaction interaction);
        Confirmation DeleteInteraction(int id);

        List<Reminder> GetReminders(object query);
        Reminder GetReminder(int id);
        Confirmation DeleteReminder(int id);
        Confirmation DelayReminder(TimeSpan delayAmount);
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumber { get; set; }
        public List<string> Email { get; set; }
        public List<Address> Address { get; set; }
        public DateTime Birthday { get; }
        public ContactFrequency Frequency { get; set; }
    }

    public class Address
    { }

    public class Interaction
    { }

    public class ContactFrequency
    { }

    public class Reminder
    {
        public enum Type
        {
            FrequencyBased,
            Birthday,
            Anniversary
        }

        public string ContactDisplayName { get; set; }
        public DateTime Date { get; set; }
        public Type ReminderType { get; set; }
    }

    public class Confirmation
    { }
}
