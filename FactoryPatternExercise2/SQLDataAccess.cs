using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database.");
            return new List<Product> { new Product { Name = "SQLProduct1", Price = 30.0 }, new Product { Name = "SQLProduct2", Price = 40.0 } };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database.");
        }
    }
}
