// See https://aka.ms/new-console-template for more information
namespace DataConvertion {
  class DataConvertion {
    static void Main() {
      int fooConv = int.Parse("123");
      Console.WriteLine(fooConv);

      int tryInt;
      if (int.TryParse("123", out tryInt)) {
        Console.WriteLine("Cannot convert");
      }
      Console.WriteLine(tryInt);
      if (int.TryParse("asdf", out tryInt)) {
        Console.WriteLine("Cannot convert");
      }

      // Use the Convert class to convert different types arount
      string fooString = Convert.ToString(1234);
      Console.WriteLine("Converted string: " + fooString);
      bool fooBool = Convert.ToBoolean("True");
      if (fooBool) {
        Console.WriteLine("Boolean convertion turns out to be good!");
      }

      Console.WriteLine(tryInt.ToString());

      // 15M is a decimal that gets casted inside of an int
      // that gets implicitly cast to a long
      long x = (int) 15M;
      Console.WriteLine(x);
    }
  }
}
