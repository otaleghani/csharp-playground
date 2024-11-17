namespace DataStructures
{
  public class DataStructures
  {
    static void Main() {
      // Arrays => Immutable
      int[] intArray = new int[2];
      int[] y = { 9000, 1000, 1337 };
      Console.WriteLine("intArray @ 0: " + intArray[0]);;
      Console.WriteLine("y @ 0: " + y[0]);;

      intArray[1] = 1;
      Console.WriteLine("intArray @ 1: " + intArray[0]);;

      // Lists => Mutable
      List<int> intList = new List<int>();
      List<string> stringList = new List<string>();
      List<int> z = new List<int> { 9000, 1000, 1337 };

      intList.Add(1);
      Console.WriteLine("intList @ 0: " + intList[0]);;
    }
  }
}
