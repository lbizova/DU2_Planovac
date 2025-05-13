namespace DU2_LB_Planovac;

class Program
{
    static void Main(string[] args)
    {
    List<Event> events = new List<Event>(); // List of events

    Console.WriteLine("Welcome to the event manager!");
    Console.WriteLine("Please enter your command:");
    Console.WriteLine("EVENT;[event name];[event date in YYYY-MM-DD format] to add an event");
    Console.WriteLine("LIST to list all events");
    Console.WriteLine("STATS to show statistics");
    Console.WriteLine("END to end the program");
    
    while (true)
    {
      string input = Console.ReadLine(); 
      string[] inputParts = input.Split(';'); // rozdelime vstup na casti
      if (string.Equals(inputParts[0] , "EVENT", StringComparison.OrdinalIgnoreCase))  // pokud je prvni cast EVENT, tak vytvorime novou udalost
      {
        string name = inputParts[1]; // jmeno udalosti je druha cast vstupu
        string dateString = inputParts[2]; // datum udalosti je treti cast vstupu
        //rozdělení data na rok, měsíc a den:
        string[] dateParts = dateString.Split('-');
        int year = int.Parse(dateParts[0]);
        int month = int.Parse(dateParts[1]);
        int day = int.Parse(dateParts[2]);
        DateTime date = new DateTime(year, month, day);       
        //DateTime date = DateTime.Parse(dateString); // prevod stringu na datum
        Event newEvent = new Event(name, date); // vytvorime novou udalost
        events.Add(newEvent); // pridame udalost do seznamu udalosti
        Console.WriteLine("Event added");
      }
      else if (string.Equals (inputParts[0] , "LIST" , StringComparison.OrdinalIgnoreCase)) // pokud je prvni cast LIST, tak vypiseme vsechny udalosti
      {
        foreach (Event e in events)
        {
          TimeSpan difference = e.Date - DateTime.Now;
          if (difference.Days > 0)
          {
            Console.WriteLine ($"Event {e.Name} with date {e.Date} will happen in {difference.Days} days");
          }
          else if (difference.Days < 0)
          {
            Console.WriteLine ($"Event {e.Name} with date {e.Date} happened {-difference.Days} days ago");
          }
          else
          {
            Console.WriteLine ($"Event {e.Name} with date {e.Date} is happening today");
          }
        }
      }
      else if (string.Equals (inputParts[0] , "STATS" , StringComparison.OrdinalIgnoreCase)) // pokud je prvni cast STATS, tak vypiseme statistiku
      {
        Dictionary<DateTime, int> stats = new Dictionary<DateTime, int>(); // vytvorime slovnik pro statistiku
        foreach (Event e in events)
        {
          if (stats.ContainsKey(e.Date)) // pokud uz datum existuje v statistice, tak zvysime pocet udalosti o 1
          {
            stats[e.Date]++;
          }
          else // pokud datum neexistuje v statistice, tak ho pridame a nastavime pocet udalosti na 1
          {
            stats[e.Date] = 1;
          }
        }
        foreach (KeyValuePair<DateTime, int> pair in stats) // vypiseme statistiku
        {
          Console.WriteLine ($"Date: {pair.Key}: events: {pair.Value}");
        }
      }
      else if (string.Equals(inputParts[0] , "END" , StringComparison.OrdinalIgnoreCase)) // pokud je prvni cast END, tak ukoncime program
      {
        break;
      }
    }
    }
}
