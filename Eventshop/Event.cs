using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventshop {

  public class Event {
    public int ID { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public string Place { get; set; }
    public double PricePerPerson { get; set; }
    public int FreePlaces { get; set; }
  }
}
