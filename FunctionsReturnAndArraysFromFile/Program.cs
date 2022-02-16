using System;

namespace FunctionsReturnAndArraysFromFile
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayRandomFood();
			DisplayRandomDrink();
			DisplayRandomMovie();
		}

		private static void DisplayRandomFood()
		{
			string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
			Random rnd = new Random();
			int RandomIndex = rnd.Next(0, foods.Length);

			string randomFood = foods[RandomIndex];
			Console.WriteLine($"Computer picked: {randomFood}");
		}

		private static void DisplayRandomDrink()
		{
			string[] drinks = { "coca-cola", "fanta", "sprite", "beer", "vodka" };
			Random rnd = new Random();
			int RandomIndex = rnd.Next(0, drinks.Length);

			string randomDrink = drinks[RandomIndex];
			Console.WriteLine($"Computer picked: {randomDrink}");
		}

		private static void DisplayRandomMovie()
		{
			string[] movies = { "Don't Look Up", "Red Notice", "The Revenant", "The Green Mile", "Theory of Everything" };
			Random rnd = new Random();
			int RandomIndex = rnd.Next(0, movies.Length);

			string randomMovie = movies[RandomIndex];
			Console.WriteLine($"Computer picked: {randomMovie}");
		}


	}
}
