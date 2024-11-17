namespace Operators
{
  class Operator {
    static void Main() {
      Console.WriteLine("Operators");

      int i1 = 1, i2 = 2;

      Console.WriteLine(i1 + i2 - i1 * 3 / 7);
      Console.WriteLine("Modulo: " + (i1 % i2));

      Console.WriteLine("3 == 2? " + (3 == 2));
      Console.WriteLine("3 != 2? " + (3 != 2));
      Console.WriteLine("3 < 2? " + (3 < 2));
      Console.WriteLine("3 > 2? " + (3 > 2));
      Console.WriteLine("3 <= 2? " + (3 <= 2));
      Console.WriteLine("3 >= 2? " + (3 >= 2));

      Console.WriteLine("\nBitwise Operators");
      Console.WriteLine("Unary bitwise complement: " + (~i1));
      Console.WriteLine("Signed left shift: " + (i1 << i2));
      Console.WriteLine("Signed right shift: " + (i1 >> i2));
      Console.WriteLine("Bitwise AND: " + (i1 & i2));
      Console.WriteLine("Bitwise inclusive OR: " + (i1 | i2));
      Console.WriteLine("Bitwise exclusive OR: " + (i1 ^ i2));

      Console.WriteLine("\nIncrementing");
      int i = 0;
      Console.WriteLine(i++);
      Console.WriteLine(++i);
      Console.WriteLine(i--);
      Console.WriteLine(--i);
    }
  }
}
