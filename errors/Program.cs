using System.Diagnostics;

namespace Errors {
  class Errors {
    static void Main() {
      try {
        string some = "";
        if (true) some = null;
        some.ToLower();
      } 
      catch (NotSupportedException) {
        Console.WriteLine("Not supported Exeption");
      } 
      catch (Exception ex) {
        Console.WriteLine("Anvedi nando, che errore!");
        Console.WriteLine(ex);
      }
      finally {
        Console.WriteLine("got out from that mess");

        int x = 0;
        Debug.Assert(x > 0, "x should be greater!");
      }

      ThrowsError();
    }

    static void ThrowsError() {
      throw new ApplicationException("A new exeption!");
    }

  }
}
