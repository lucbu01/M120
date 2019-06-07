using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventshop {
  class Order {
    public int ID { get; set; }
    public int CountPerson { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Address { get; set; }
    public string PostalCodeAndPlace { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Event Event { get; set; }
  }
}
