// See https://aka.ms/new-console-template for more information
namespace Classes {
  class Class {
    static void Main() {
      Console.WriteLine("helo");
      Console.WriteLine(Bicycle.Run(1, 2, "speed"));

      int maxSpeed = 0;
      int minSpeed = 1;
      Console.WriteLine(maxSpeed + " " + minSpeed);
      Bicycle.RunByReference(ref maxSpeed, out minSpeed);
      Console.WriteLine(maxSpeed + " " + minSpeed);

      string result;
      bool isDrugFree = Bicycle.IsRunnerDrugFree(out result);
      if (isDrugFree) {
        Console.WriteLine("Here's the result... What a shame: " + result);
      } else {
        Console.WriteLine("There you go buddy, the results are in: " + result);
      }
    }
  }

  class Bicycle {
    public static string Run(int speed, float acceleration = 3, params string[] otherParams) {
      float runningAt = (float) speed * acceleration;

      string runner;
      if (otherParams[0] != "") {
        runner = otherParams[0];
      } else {
        var runnerObj = GetRunner();
        runner = runnerObj.Name;
      }

      return string.Format("Runner {0} is running at {1}", runner, runningAt);
    }

    public static void RunByReference(ref int maxSpeed, out int minSpeed) {
      minSpeed = 15;
      maxSpeed = 15;
      Console.WriteLine(maxSpeed + " " + minSpeed);
    }
    
    // Multiple return with out
    public static bool IsRunnerDrugFree(out string result) {
      result = "Absolutely not, in this day and age testosterone is a light snack.";
      return false;
    }

    // Multiple returns with tuple
    static (string Name, int Age) GetRunner() {
      return ("Gennaro", 30);
    }
  }
}
