using System;

namespace FridayNightRandomReturn
{
	class Program
	{
		static void Main(string[] args)
		{
			string randomFood, randomDrink, randomMovie;
			string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
			string[] drinks = { "coca-cola", "fanta", "sprite", "beer", "vodka" };
			string[] movies = { "Don't Look Up", "Red Notice", "The Revenant", "The Green Mile", "Theory of Everything" };

			randomFood = PickRandomElementFromArray(foods);
			randomDrink = PickRandomElementFromArray(drinks);
			randomMovie = PickRandomElementFromArray(movies);

			Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}.");
		}


		private static int GenerateRandomIndex(string[] someArray)
		{
			Random rnd = new Random();
			int RandomIndex = rnd.Next(0, someArray.Length);

			return RandomIndex;
		}

		private static string PickRandomElementFromArray(string[] someArray)
		{

			string randomElement = someArray[GenerateRandomIndex(someArray)];
			return randomElement;

		}

		/*private static void DisplayRandomDrink()
		{
			Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
		}

		private static void DisplayRandomMovie()
		{
			Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
		}*/


	}
}
