using System;

class Program {
  public static void Main (string[] args) {
    var temperatures = new int[5];
    var copied = new int[5];
    var valuesEntered = 0;
    while (valuesEntered < 5) {
      Console.Write("INPUT Temperature ");
      var temperature = Convert.ToInt32(Console.ReadLine());
      if (temperature < -30 || temperature > 130) {
        Console.WriteLine("EXCEPTION Temperature {0} is invalid, Please enter a valid temperature between -30 and 130", temperature);
        continue;
      }
      temperatures[valuesEntered] = temperature;
      copied[valuesEntered] = temperature;
      valuesEntered ++;
    }
    Array.Sort(copied);
    var arraysEqual = true;
    for (int i = 0; i < copied.Length; i++) {
      if (copied[i] != temperatures[i])
        arraysEqual = false;
    }
    if (arraysEqual) {
      Console.WriteLine("OUTPUT Getting Warmer");
      
    } else {
      Array.Reverse(copied);
      arraysEqual = true;
      for (int i = 0; i < copied.Length; i++) {
        if (copied[i] != temperatures[i])
          arraysEqual = false;
      }
      if (arraysEqual) {
        Console.WriteLine("OUTPUT Getting Colder");
      } else {
        Console.WriteLine("OUTPUT It's a mixed bag");
      }
    }
    
    Console.Write("OUTPUT 5-day Temperature [");
    for (var i = 0; i < temperatures.Length; i++) {
      if (i == temperatures.Length - 1) 
        Console.Write(temperatures[i]);
      else
        Console.Write("{0}, ", temperatures[i]);
    }
    Console.WriteLine("]");

    var sum = 0.0;
    foreach (var temp in temperatures) {
      sum+=temp;
    }
    Console.WriteLine("OUTPUT Average Temperature is {0} degrees", sum/temperatures.Length);
    Console.WriteLine("Passed");
  }
}