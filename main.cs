using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 1;
    int total = 0;

    while(counter < 8)
    {
      Console.WriteLine("Enter the distance traveled by car #" + counter);
      int distance = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car #" + counter);
      int time = Convert.ToInt32(Console.ReadLine());
      int s = distance/time; 
      Console.WriteLine("The speed of the car is " + s + " miles per hour");
      total = total + s;
      counter++;
    
      

    }
    double average = total / 7;
    Console.WriteLine("The average speed of the 7 cars is " + average + " miles per hour");

  }
}