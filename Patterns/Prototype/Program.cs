using System;

namespace Prototype
{
    class Program
    {
         static CalendarEvent GetExistingEvent()
        {
            var beerParty = new CalendarEvent();
            var friends = new Attendee[1];

            var andriy = new Attendee("Vladyslav", "Impaler");

            friends[0] = andriy;

            beerParty.Attendees = friends;
            beerParty.StartDateAndTime = new DateTime(2019, 11, 23);
            beerParty.Priority = Priority.High;

            return beerParty;

        }

        static void Main(string[] args)
        {
            var beerParty = GetExistingEvent();
            var nextFridayEvent = (CalendarEvent)beerParty.Clone();
            nextFridayEvent.StartDateAndTime = new DateTime(2019, 10, 23);
            nextFridayEvent.Attendees[0].EmailAdress = "andriybuday@liamg.com";
            nextFridayEvent.Priority = Priority.High;
            if (beerParty.Attendees != nextFridayEvent.Attendees)
            {
                Console.WriteLine("Event has own list of attendees");
            }
            if (beerParty.Attendees[0].EmailAdress == nextFridayEvent.Attendees[0].EmailAdress)
            {
                Console.WriteLine("Update to my e-mail adress will be reflected in all events");
            }
            if (beerParty.Priority != nextFridayEvent.Priority)
            {
                Console.WriteLine("Each event should have own priority object, fully-copied");
            }

        }
    }
}
