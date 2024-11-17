// See https://aka.ms/new-console-template for more information
namespace ControlStructures {
  class ControlStructure {
    static void Main() {
      Console.WriteLine("Control structures");
      int j = 10;
      if (j == 10) {
        Console.WriteLine("I fired");
      } else if (j > 10) {
        Console.WriteLine("I didn't fired");
      } else {
        Console.WriteLine("Also I didn't fire");
      }

      int toCompare = 17;
      string isTrue = toCompare == 17 ? "yes" : "nope";
      Console.WriteLine("Is the number 17? " + isTrue);

      int fooWhile = 0;
      while (fooWhile < 100) {
        fooWhile++;
        if (fooWhile > 89) {
          Console.WriteLine(100 - fooWhile);
        }
      }
      Console.WriteLine("Blastoff!");

      int fooDoWhile = 0;
      do {
        //if (false) continue;
        fooDoWhile++;
        if (fooDoWhile == 50) {
          Console.WriteLine("Got out");
          break;
        }
      } while (fooDoWhile < 100);

      for (int fooFor = 0; fooFor < 9; fooFor++) {
        if (fooFor == 8) {
          Console.WriteLine("8!!");
        }
      }

      foreach (char character in "Hello world!") {
        Console.WriteLine(character);
      }

      int month = 3;
      string monthString;
      switch (month) {
        case 1:
          monthString = "january";
          break;

        case 2:
          monthString = "february";
          break;

        case 3:
          monthString = "march";
          break;

        case 6:
        case 7:
        case 8:
          monthString = "summer time";
          break;


        default:
          monthString = "some other month";
          break;
      }
      
      Console.WriteLine(monthString);
    }
  }
}
