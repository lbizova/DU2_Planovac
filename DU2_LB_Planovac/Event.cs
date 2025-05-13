using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DU2_LB_Planovac
{
    public class Event
    {
            public string Name { get; set; }
    public DateTime Date { get; set; }
    public Event (string name, DateTime date)
  {
      Name = name;
      Date = date;
      Console.WriteLine("Event created");
  }
    }
}