using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventshop {
  public class Events {
    private static List<Event> events = initializeEvents();
    private static List<Event> pastEvents = initializePastEvents();

    private static List<Event> initializePastEvents() {
      List<Event> events = new List<Event>();
      events.Add(new Event {
        ID = 1,
        Date = new DateTime(2018, 7, 31),
        Name = "Bligg",
        Place = "Sursee",
        PricePerPerson = 10,
        FreePlaces = 5
      });
      events.Add(new Event {
        ID = 2,
        Date = new DateTime(2018, 8, 2),
        Name = "Müslüm",
        Place = "Zürich",
        PricePerPerson = 35,
        FreePlaces = 90
      });
      events.Add(new Event {
        ID = 3,
        Date = new DateTime(2019, 7, 20),
        Name = "Die Toten Hosen",
        Place = "Rain",
        PricePerPerson = 15,
        FreePlaces = 150
      });
      return events;
    }

    public static List<Event> get() { return events; }
    public static List<Event> getPast() { return pastEvents; }

    private static List<Event> initializeEvents() {
      List<Event> events = new List<Event>();
      events.Add(new Event {
        ID = 11,
        Date = new DateTime(2019, 7, 20),
        Name = "Die Toten Hosen",
        Place = "Rain",
        PricePerPerson = 15,
        FreePlaces = 150
      });
      events.Add(new Event {
        ID = 12,
        Date = new DateTime(2020, 7, 31),
        Name = "Bligg",
        Place = "Sursee",
        PricePerPerson = 10,
        FreePlaces = 5
      });
      events.Add(new Event {
        ID = 13,
        Date = new DateTime(2020, 8, 2),
        Name = "Müslüm",
        Place = "Zürich",
        PricePerPerson = 35,
        FreePlaces = 90
      });
      events.Add(new Event {
        ID = 14,
        Date = new DateTime(2020, 8, 20),
        Name = "DJ Bobo",
        Place = "Rust (D)",
        PricePerPerson = 55,
        FreePlaces = 34
      });
      events.Add(new Event {
        ID = 15,
        Date = new DateTime(2020, 12, 21),
        Name = "Fäaschtbänkler",
        Place = "Mallorca (E)",
        PricePerPerson = 2,
        FreePlaces = 35
      });
      events.Add(new Event {
        ID = 16,
        Date = new DateTime(2021, 7, 31),
        Name = "Heitere",
        Place = "Zofingen",
        PricePerPerson = 150,
        FreePlaces = 233
      });
      return events;
    }
  }
}
