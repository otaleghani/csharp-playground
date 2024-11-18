using System.Dynamic;

namespace DynamicObj
{
  class DynamicObj
  {
    static void Main() 
    {
      dynamic student = new ExpandoObject();
      student.FirstName = "gennaro";
      student.LastName = "bullo";

      student.Introduce = new Func<string, string>(
        (introduceTo) => string.Format("helo {0}, this is {1}", introduceTo, student.FirstName));
      Console.WriteLine(student.introduceTo("sandro"));
    }
  }
}
