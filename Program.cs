using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1st program
			int a = 10, b = 20;
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine($"after swapping a={a},b={b}");


			//2nd program
			Console.WriteLine("enter 1st no");
			int c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter 2nd no ");
			int d = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter 3rd no");
			int e = Convert.ToInt32(Console.ReadLine());

			int f = c * d * e;
			Console.WriteLine($"{c}x{d}x{e}= {f}");

			//3rd program

			Console.WriteLine("enter first no");
			int g = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter second no");
			int h = Convert.ToInt32(Console.ReadLine());

			int add = g + h;
			int sub = g - h;
			int mul = g * h;
			int div = g / h;
			int mod = g % h;

			Console.WriteLine($"{g}+{h} = {add}");
			Console.WriteLine($"{g}-{h} = {sub}");
			Console.WriteLine($"{g}*{h} = {mul}");
			Console.WriteLine($"{g}/{h} = {div}");
			Console.WriteLine($"{g}%{h} = {mod}");



			//4th program

			double x, y, z;
			Console.WriteLine("enter x,y,z");
			x = double.Parse(Console.ReadLine());
			y = double.Parse(Console.ReadLine());
			z = double.Parse(Console.ReadLine());

			double result1 = (x + y) * z;
			double result2 = (x * y) + (y * z);

			Console.WriteLine($"(x+y)*z= {result1},(x*y)+ (y*z)={result2})");




			//5th program

			// Prompt user for input
			Console.Write("Enter a digit: ");

			// Read the input and convert it to an integer
			int number = Convert.ToInt32(Console.ReadLine());

			// Using string 
			Console.WriteLine("{0} {0} {0} {0}", number);
			Console.WriteLine("{0}{0}{0}{0}", number);

			// Using Console.Write
			Console.WriteLine($"{number} {number} {number} {number}");
			Console.WriteLine($"{number}{number}{number}{number}");


			//6th program

			Console.Write("Enter the first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());


			Console.Write("Enter the second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			// Find and display the maximum and minimum
			int max = Math.Max(number1, number2);
			int min = Math.Min(number1, number2);

			Console.WriteLine($"Maximum: {max}");
			Console.WriteLine($"Minimum: {min}");


			//7th program


			Console.Write("Enter marks for Subject 1: ");
			int subject1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter marks for Subject 2: ");
			int subject2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter marks for Subject 3: ");
			int subject3 = Convert.ToInt32(Console.ReadLine());

			// Calculate total marks and percentage
			int totalMarks = subject1 + subject2 + subject3;
			double percentage = (totalMarks / 3.0);


			string grade;
			if (percentage < 35)
			{
				grade = "Fail";
			}
			else if (percentage >= 35 && percentage < 45)
			{
				grade = "Third";
			}
			else if (percentage >= 45 && percentage < 60)
			{
				grade = "Second";
			}
			else
			{
				grade = "First";
			}

			// Display results
			Console.WriteLine($"Total Marks: {totalMarks}");
			Console.WriteLine($"Percentage: {percentage:F2}%");
			Console.WriteLine($"Grade: {grade}");

			//8th program
			Console.Write("Enter the amount of Celsius: ");
			double celsius = Convert.ToDouble(Console.ReadLine());

			// Convert Celsius to Kelvin
			double kelvin = celsius + 273.15;

			// Convert Celsius to Fahrenheit
			double fahrenheit = (celsius * 9 / 5) + 32;

			// Display results
			Console.WriteLine($"Kelvin = {kelvin:F0}");
			Console.WriteLine($"Fahrenheit = {fahrenheit:F2}");

			//9th program

			// Prompt user for two integers
			Console.Write("Enter the first integer: ");
			int numb1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the second integer: ");
			int numb2 = Convert.ToInt32(Console.ReadLine());

			// Compute the sum
			int sum = numb1 + numb2;

			// Check if the two values are equal
			if (numb1 == numb2)
			{
				// If equal, return the triple of their sum
				int result = 3 * sum;
				Console.WriteLine($"The two values are equal. Triple of their sum is: {result}");
			}
			else
			{
				// If not equal, return the regular sum
				Console.WriteLine($"The sum of the two values is: {sum}");
			}

			//10th program
			// Prompt user for two numbers
			Console.Write("Enter the first number: ");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter the second number: ");
			double num2 = Convert.ToDouble(Console.ReadLine());

			// Calculate the absolute value of the difference
			double difference = Math.Abs(num1 - num2);

			// Check if the first number is greater than the second
			if (num1 > num2)
			{
				// Return double the absolute value of the difference
				double result = 2 * difference;
				Console.WriteLine($"The first number is greater. Double the absolute difference is: {result}");
			}
			else
			{
				// Return the regular absolute value of the difference
				Console.WriteLine($"The absolute difference of the two numbers is: {difference}");
			}

			//11th program
			// Prompt user for the number of days
			Console.Write("Enter the number of days: ");
			int totalDays = Convert.ToInt32(Console.ReadLine());

			// Calculate years, weeks, and remaining days
			int years = totalDays / 365;
			int remainingDays = totalDays % 365;
			int weeks = remainingDays / 7;
			int days = remainingDays % 7;

			// Display the result
			Console.WriteLine($"{totalDays} days is approximately:");
			Console.WriteLine($"Years: {years}");
			Console.WriteLine($"Weeks: {weeks}");
			Console.WriteLine($"Days: {days}");







			Console.Read();
		}
	}
}
