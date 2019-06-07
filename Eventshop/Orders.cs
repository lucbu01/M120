using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventshop {
  class Orders {
    private static List<Order> orders = initialize();
    private static List<Order> pastOrders = initializePast();

    public static List<Order> get() { return orders; }
    public static List<Order> getPast() { return pastOrders; }

    private static List<Order> initialize() {
      List<Order> orders = new List<Order>();
      orders.Add(new Order {
        ID = 11,
        Event = Events.get()[0],
        CountPerson = 2,
        FirstName = "Lars",
        LastName = "Ghezzi",
        Address = "Hauptstrasse 3",
        PostalCodeAndPlace = "6210 Sursee",
        Email = "lars.ghezzi@gmail.com",
        Phone = "025 651 25 78"
      });
      return orders;
    }

    private static List<Order> initializePast() {
      List<Order> orders = new List<Order>();
      orders.Add(new Order {
        ID = 1,
        Event = Events.getPast()[0],
        CountPerson = 2,
        FirstName = "Lars",
        LastName = "Ghezzi",
        Address = "Hauptstrasse 3",
        PostalCodeAndPlace = "6210 Sursee",
        Email = "lars.ghezzi@gmail.com",
        Phone = "025 651 25 78"
      });
      return orders;
    }
  }
}
