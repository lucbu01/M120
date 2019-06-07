using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventshop {
  class Orders {
    private static List<Order> orders = initialize();

    public static List<Order> get() { return orders; }

    private static List<Order> initialize() {
      List<Order> orders = new List<Order>();

      return orders;
    }
  }
}
