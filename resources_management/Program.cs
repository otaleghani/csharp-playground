namespace ResManagement
{
  class ResManagement {
    static void Main() {
      // Basically using is used to handle unmanaged resources.
      // The using statement takes care of cleaning the IDisposable objects.
      // So if an exception is thrown, the resource will be released
      using (StreamWriter writer = new StreamWriter("log.txt"))
      {
        writer.WriteLine("One line");
        writer.WriteLine("One line");
      }

      using (StreamReader reader = new StreamReader("log.txt")){
        // Read consumes the stream
        Console.WriteLine(reader.ReadLine());
        Console.WriteLine(reader.Peek());
        Console.WriteLine(reader.Read());
        Console.WriteLine(reader.ReadLine());

        // So this one would basically return an empty line
        Console.WriteLine(reader.ReadLine());

      }

      
    }
  }
}
