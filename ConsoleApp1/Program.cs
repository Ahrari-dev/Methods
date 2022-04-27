using System;

namespace MethodsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------Exercise 1
            //Name: Hasib
            //Favorite Color: Green
            //Favorite Animal: Wolf
            //Favorite Band: Breaking Benjamin

            //Console.WriteLine("Hello, What is your first name?");
            //var userName = Console.ReadLine();

            //Console.WriteLine($"Hello {userName}, what is your favorite color?");
            //var favoriteColor = Console.ReadLine();

            //Console.WriteLine($"{favoriteColor} is a great color! How about your favorite animal?");
            //var favoriteAnimal = Console.ReadLine();

            //Console.WriteLine($"Mine too! The {favoriteAnimal} is a great animal. Lastly, what is your favorite band?");
            //var favoriteBand = Console.ReadLine();

            //Console.WriteLine($"Thanks {userName}! Here is your profile.");

            //Console.WriteLine($"Name: {userName}");
            //Console.WriteLine($"Favorite Color: {favoriteColor}");
            //Console.WriteLine($"Favorite Animal: {favoriteAnimal}");
            //Console.WriteLine($"Favorite Band: {favoriteBand}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Gibe me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The sum is: {product}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}