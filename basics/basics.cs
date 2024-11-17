//using System.Dynamic;
namespace Basics

{
  public class Basics
  {
    //void Method(string firstParam) {
    //  Console.WriteLine("Helo");
    //}
    public static void Main() {
      //Method(firstParam: "sus");
      System.Console.WriteLine("Helo");
      System.Console.WriteLine();
      //System.Console.Clear();

      System.Console.WriteLine(
          "Integer: " + 10 +
          " Double: " + 3.14 +
          " Boolean: " + true);

      System.Console.Write("Hello ");
      System.Console.Write("world!");

      // Signed 8-bit integer
      // -128, 127
      sbyte fooSbyte = 100;
      System.Console.WriteLine(fooSbyte);

      // Unsigned 8-bit integer
      // 0, 255
      byte fooByte = 200;
      System.Console.WriteLine(fooByte);

      // Short - 16-bit integer
      short fooShort = 10000;
      ushort fooUshort = 10000;
      System.Console.WriteLine(fooShort + " " + fooUshort);

      // int - 32-bit integer
      int fooInt = 10000;
      uint fooUint = 10000;
      System.Console.WriteLine(fooInt + " " + fooUint);

      // Long - 64-bit integer
      long fooLong = 10000;
      ulong fooUlong = 10000;
      System.Console.WriteLine(fooLong + " " + fooUlong);

      // Decimal
      double fooDouble = 12.4;
      float fooFloat = 235.5f;
      decimal fooDecimal = 235.5m;
      System.Console.WriteLine(fooDouble + " " + fooFloat + " " + fooDecimal);

      bool fooBool = true;
      System.Console.WriteLine(fooBool);

      char fooChar = 'a';
      string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";
      System.Console.WriteLine(fooChar + fooString);

      char charFromString = fooString[1];
      System.Console.WriteLine(charFromString);

      System.Console.WriteLine(string.Compare(fooString, "x", StringComparison.CurrentCultureIgnoreCase));

      string fooFs = string.Format("Check Check, {0} {1}, {0} {1:0.0}", 1, 2);
      System.Console.WriteLine(fooFs);

      DateTime fooDate = DateTime.Now;
      System.Console.WriteLine(fooDate.ToString("hh:mm, dd MMM yyyy"));

      string path = "C:\\Users\\User\\Desktop";
      string verbatimPath = @"C:\Users\User\Desktop";
      Console.WriteLine(path == verbatimPath);

      string bazString = @"
        new line wow
        incredible
        ";
      Console.WriteLine(bazString);

      const int HoursWorkPerWeek = 9001;
      Console.WriteLine(HoursWorkPerWeek);
    }
  }
}
