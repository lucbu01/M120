using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventshop {
  public class Events {
    private static List<Event> events = initialize();

    public static List<Event> get() { return events; }

    private static List<Event> initialize() {
      List<Event> events = new List<Event>();
      events.Add(new Event {
        ID = 1,
        Date = new DateTime(2019, 6, 20),
        Name = "Die Toten Hosen",
        Place = "Rain",
        PricePerPerson = 15,
        FreePlaces = 150
      });
      events.Add(new Event {
        ID = 2,
        Date = new DateTime(2020, 7, 31),
        Name = "Bligg",
        Place = "Sursee",
        PricePerPerson = 10,
        FreePlaces = 5
      });
      events.Add(new Event {
        ID = 3,
        Date = new DateTime(2020, 8, 2),
        Name = "Müslüm",
        Place = "Zürich",
        PricePerPerson = 35,
        FreePlaces = 90
      });
      events.Add(new Event {
        ID = 4,
        Date = new DateTime(2020, 8, 20),
        Name = "DJ Bobo",
        Place = "Rust (D)",
        PricePerPerson = 55,
        FreePlaces = 34
      });
      events.Add(new Event {
        ID = 5,
        Date = new DateTime(2020, 12, 21),
        Name = "Fäaschtbänkler",
        Place = "Mallorca (E)",
        PricePerPerson = 2,
        FreePlaces = 35
      });
      events.Add(new Event {
        ID = 6,
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
