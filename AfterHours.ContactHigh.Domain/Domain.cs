using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterHours.ContactHigh.Domain
{

    public class Junk
    {
        public void doStuff()
        {
            var Address = new Address("123 Main", new Location("Dallas", "TX"), Domain.Address.AddressType.Home);
        }
    }


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

    public class PersonService
    {
        public Confirmation AddPerson(Person person) {

            // create reminders
            

            return null;
        }


    }

    public class InteractionService
    {

        public Confirmation ChangeInteractionDate(Interaction interaction, DateTime date)
        {


            return null;
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            LastInteractionDate = DateTime.Today;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<string> PhoneNumber { get; set; }
        public List<string> Email { get; set; }
        public List<Address> Address { get; set; }
        public DateTime Birthday { get; }
        public ContactFrequency Frequency { get; set; }
        public DateTime LastInteractionDate { get; set; }

        public class Address
        {

            private Location _location;

            public Address(string line1, Location location, AddressType type)
            {
                Line1 = line1;
                _location = location;
                Type = type;
            }

            public enum AddressType
            {
                Home, 
                Work,
                Other
            }

            public string Line1 { get; private set; }
            public string Line2 { get; set; }
            public string Line3 { get; set; }
            public string City 
            {
                get 
                { 
                    return _location.City; 
                }
            }
            public string State
            {
                get
                {
                    return _location.State;
                }
            }
            public string Zip { get; set; }
            public AddressType Type { get; set; }
        }
    }


    public class Location
    {
        public Location(string city, string state)
        {
            City = city;
            State = state;
        }

        public string City { get; private set; }
        public string State { get; private set; }
    }

    public class Interaction
    {
        public Interaction(Guid personId, DateTime date, string interactionType)
        {
            Date = date;
        }

        public DateTime Date { get; set; }
        public string InteractionType { get; private set; }
    }

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
    