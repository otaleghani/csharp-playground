
namespace Parallelz
{
  class Parallelz
  {
    static void Main() 
    {
      var words = new List<string> { "dog", "cat", "alberto" };

      Parallel.ForEach(words,
        new ParallelOptions() { MaxDegreeOfParallelism = 4 },
        word =>
        {
          Console.WriteLine(word);
        }
      );

      Parallel.For(0, 5, num =>{
        Console.WriteLine(num);
      });
    }
  }
}
