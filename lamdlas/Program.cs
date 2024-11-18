namespace Lambdas {
  class Lambda {
    static void Main() {
      Func<int, int> square = (x) => x * x;

      Console.WriteLine(square(3));

      Func<string, string> prefix = (x) => "Sir. " + x;
      Console.WriteLine(prefix("gianni"));

      // First the args, last is the return
      Func<string, int, string> formatAge = (x, y) => String.Format("My name is {0} and I'm {1} years old", x, y);

      Console.WriteLine(formatAge(prefix("gianni"), 20));
    }
  }
}
