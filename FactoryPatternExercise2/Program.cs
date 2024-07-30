using System;

namespace FactoryPatternExercise2


{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use: List, SQL, or Mongo?");
            string userChoice = Console.ReadLine();

            try
            {
                IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(userChoice);
                var products = dataAccess.LoadData();
                dataAccess.SaveData();

                // Display the products loaded
                Console.WriteLine("Products loaded:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

