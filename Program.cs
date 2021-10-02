using System;

namespace Practice
{
  class Program
  {
    static void Main(string[] args)
    {
      //calculating the area of a rectangle
      Console.WriteLine("Enter the height: ");
      double height = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the width: ");
      double width = Convert.ToDouble(Console.ReadLine());
      double area = height * width;
      Console.WriteLine($"The rectangle area is {area}\n");
      Console.WriteLine("Hit Enter to check the median of five numbers or the grade of a student");
      Console.ReadKey();

      //Accumulated sum
      double accumulatedSum = 0;

      //Asking user for five numbers and getting the average of the five numbers provided by the user
      Console.WriteLine("Please enter a number: ");
      accumulatedSum = accumulatedSum + Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Please enter a second: ");
      accumulatedSum = accumulatedSum + Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Please enter a third number: ");
      accumulatedSum = accumulatedSum + Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Please enter a fourth number: ");
      accumulatedSum = accumulatedSum + Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Please enter a fifth number: ");
      accumulatedSum = accumulatedSum + Convert.ToDouble(Console.ReadLine());

      double media = accumulatedSum / 5;
      Console.WriteLine($"The median of the five numbers provides is: {media}");
      Console.ReadKey();
    }
  }
}
