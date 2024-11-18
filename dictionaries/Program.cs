namespace Dictionaries
{
  class Dictionary {
    static void Main() {
      var phonebook = new Dictionary<string, string>() {
        { "sandro", "333 444 5555"},
        { "alberto", "333 444 5555"},
      };

      phonebook["giuliano"] = "333 444 5555";

      Console.WriteLine(phonebook["sandro"]);
      Console.WriteLine(phonebook["giuliano"]);

      phonebook.Add("genny", "112233");
      Console.WriteLine(phonebook["genny"]);

      if (phonebook.TryAdd("genny", "223344")) {
        Console.WriteLine(phonebook["genny"]);
      } else {
        Console.WriteLine("cannot add, already present.");
      }

      phonebook.Clear();
      
      if (!phonebook.TryGetValue("genny", out string? data)) 
        Console.WriteLine("genny not found");
      
      if (phonebook.TryAdd("genny", "2")) 
        Console.WriteLine("genny added");

      if (phonebook.TryGetValue("genny", out string? data2))
        Console.WriteLine(data2);

      phonebook.Remove("genny");

      Console.WriteLine("The type of phonebook is: " + phonebook.GetType());

      Console.WriteLine(phonebook.GetHashCode()); 
    }
  }
}
