using System;

namespace FridayNightRandom
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayRandomFood();
			DisplayRandomDrink();
			DisplayRandomMovie();
		}

		private static int GenerateRandomIndex(string[] someArray)
		{
			Random rnd = new Random();
			int RandomIndex = rnd.Next(0, someArray.Length);

			return RandomIndex;
		}

		private static void DisplayRandomFood()
		{
			string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

			Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
		}

		private static void DisplayRandomDrink()
		{
			string[] drinks = { "coca-cola", "fanta", "sprite", "beer", "vodka" };

			Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
		}

		private static void DisplayRandomMovie()
		{
			string[] movies = { "Don't Look Up", "Red Notice", "The Revenant", "The Green Mile", "Theory of Everything" };

			Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
		}


	}
}
