namespace Generics {
  class Generic {
    public static void Main() {
      int fooInt = 5;
      PrintValue(fooInt);

      Dictionary<string, int> ages = new Dictionary<string, int>();
      int age = SetDefault(ages, "alberto", 30);
      Console.WriteLine(ages["alberto"]);

      List<string> names = new List<string> { "alberto", "gennaro", "irma" };
      IterateAndPrint(names);

      List<int> numbers = new List<int> { 1,2,3,4,5,6 };
      foreach (var x in YieldCounter(20)) {
        Console.Write(x + ", ");
      }

      // Same thing
      int? nullable = null;
      Nullable<int> nullable2 = null;
      int nullableWithDefault = nullable ?? 0;
      int nullableWithDefault2 = nullable2 ?? 0;
      Console.WriteLine(nullableWithDefault.ToString(), nullableWithDefault2.ToString());
    }

    static void PrintValue<T>(T value) {
      Console.WriteLine("value is: " + value);
    }

    static TValue SetDefault<TKey, TValue>(
      IDictionary<TKey, TValue> dict,
      TKey key,
      TValue defaultValue) 
    {
      // We do not know if TValue is always defined. C# has null types for dealing with null
      // like Option in Rust.
      // This is shorthand for Nullable<T>
      TValue? result;
      if (!dict.TryGetValue(key, out result)) {
          return dict[key] = defaultValue;
      } else {
        return result;
      }
    }

    // Create filters for which type can access this 
    static void IterateAndPrint<T>(T toPrint) where T: IEnumerable<string> {
      foreach (var item in toPrint) {
        Console.WriteLine("Name: " + item);
      }
    }

    // yield gives you the ability to work with foreach loops
    static IEnumerable<int> YieldCounter(int limit = 10) {
      for (var i = 0; i < limit; i++) {
        // And you can use more than one!
        yield return i;
        yield return i+1;
        
        // and you can even stop it with break!
        if (i > limit/2) yield break;
      }
    }
  }
}
